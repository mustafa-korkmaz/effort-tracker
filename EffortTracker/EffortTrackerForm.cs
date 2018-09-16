using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace EffortTracker
{
    public partial class EffortTrackerForm : Form
    {
        private ProjectTask _selectedProjectTask;
        private JsonRoot _jsonRoot;
        private readonly string _jsonFilePath;

        public EffortTrackerForm()
        {
            InitializeComponent();

            var basePath = AppDomain.CurrentDomain.BaseDirectory;
            _jsonFilePath = basePath + "project_tasks.json";

            FillProjects();
        }

        private void FillProjects()
        {
            cmb_projects.Items.Clear();

            try
            {
                var jsonText = File.ReadAllText(_jsonFilePath);

                _jsonRoot = JsonConvert.DeserializeObject<JsonRoot>(jsonText);

                var projects = _jsonRoot.ProjectTasks.ToArray();

                cmb_projects.Items.AddRange(projects);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmb_projects_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedProjectTask = cmb_projects.SelectedItem as ProjectTask;

            _selectedProjectTask.BreakStartDateTime = new DateTime(2000, 1, 1); //assign a default value

            GetTaskStatistics();
        }

        private void GetTaskStatistics()
        {
            switch (_selectedProjectTask.Status)
            {
                case ProjectStatus.NotWorking:
                    lbl_status.ForeColor = System.Drawing.Color.Red;
                    break;
                case ProjectStatus.Working:
                    lbl_status.ForeColor = System.Drawing.Color.ForestGreen;
                    break;
                case ProjectStatus.BreakTime:
                    lbl_status.ForeColor = System.Drawing.Color.Blue;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            lbl_task_start_date.Text = _selectedProjectTask.TaskStartDate;
            lbl_days.Text = _selectedProjectTask.TotalDaysElapsed.ToString();
            lbl_work_days.Text = _selectedProjectTask.WorkDaysElapsed.ToString();
            lbl_time.Text = GetTotalTimeElapsedText();
            lbl_status.Text = _selectedProjectTask.Status.ToString("G");
        }

        private void btn_finish_Click(object sender, EventArgs e)
        {
            if (_selectedProjectTask == null || _selectedProjectTask.Status == ProjectStatus.NotWorking)
            {
                return;
            }

            _selectedProjectTask.Status = ProjectStatus.NotWorking;

            UpdateTaskStatistics();

            UpdateJsonFile();

            GetTaskStatistics();

            FillProjects(); // refresh
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (_selectedProjectTask != null && _selectedProjectTask.Status != ProjectStatus.NotWorking)
                {
                    MessageBox.Show("Cannot exit program while a working project exists.", "Warning",
                        MessageBoxButtons.OK);
                    e.Cancel = true;
                }
                else
                    e.Cancel = false;
            }

            base.OnFormClosing(e);
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (_selectedProjectTask == null || _selectedProjectTask.Status == ProjectStatus.Working)
            {
                return;
            }

            if (_jsonRoot.ProjectTasks.Any(p => p.Status == ProjectStatus.Working))
            {
                MessageBox.Show("Cannot work more than one project at the same time.", "Warning",
                    MessageBoxButtons.OK);

                return;
            }

            if (_selectedProjectTask.Status == ProjectStatus.BreakTime)
            {
                //calculate break time in minutes
                var breakStartDate = _selectedProjectTask.BreakStartDateTime;
                var tsBreakMins = (DateTime.UtcNow - breakStartDate).TotalMinutes;

                _selectedProjectTask.BreakMinsElapsed = Convert.ToInt32(tsBreakMins);
            }
            else
            {
                _selectedProjectTask.CurrentWorkStartDateTime = DateTime.UtcNow;
            }

            _selectedProjectTask.Status = ProjectStatus.Working;

            GetTaskStatistics();
        }

        private string GetTotalTimeElapsedText()
        {
            var totalMins = _selectedProjectTask.TotalMinsElapsed;

            var hours = totalMins / 60;
            var mins = totalMins - (hours * 60);

            var hourText = hours < 10 ? "0" + hours : hours.ToString();
            var minsText = mins < 10 ? "0" + mins : mins.ToString();

            return $"{hourText} hours {minsText} mins";
        }

        private void UpdateTaskStatistics()
        {
            var lastWorkStartDate = _selectedProjectTask.LastWorkStartDateTime.ToDateTime();
            var currentWorkStartDate = _selectedProjectTask.CurrentWorkStartDateTime;

            var tsDays = (DateTime.UtcNow.Date - lastWorkStartDate.Date).Days;
            var tsMins = (DateTime.UtcNow - currentWorkStartDate).TotalMinutes;

            if (tsDays > 0)
            {
                _selectedProjectTask.WorkDaysElapsed += 1;
            }

            _selectedProjectTask.TotalMinsElapsed += Convert.ToInt32(tsMins) - _selectedProjectTask.BreakMinsElapsed;

            //refresh break time
            _selectedProjectTask.BreakMinsElapsed = 0;

            //update last work start date time
            _selectedProjectTask.LastWorkStartDateTime = currentWorkStartDate.ToDateTimeString();
        }

        private void UpdateJsonFile()
        {
            var jsonText = JsonConvert.SerializeObject(_jsonRoot);
            File.WriteAllText(_jsonFilePath, jsonText);
        }

        private void EffortTrackerForm_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notify_icon.Visible = true;
                // notify_icon.ShowBalloonTip(500);
                Hide();
            }

            else if (FormWindowState.Normal == this.WindowState)
            {
                notify_icon.Visible = false;
            }
        }

        private void notify_icon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notify_icon.Visible = false;
        }

        private void btn_break_Click(object sender, EventArgs e)
        {
            if (_selectedProjectTask == null || _selectedProjectTask.Status != ProjectStatus.Working)
            {
                return;
            }

            _selectedProjectTask.Status = ProjectStatus.BreakTime;

            GetTaskStatistics();

            _selectedProjectTask.BreakStartDateTime = DateTime.UtcNow;
        }
    }
}

