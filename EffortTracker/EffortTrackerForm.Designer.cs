namespace EffortTracker
{
    partial class EffortTrackerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_task_name_title = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.cmb_projects = new System.Windows.Forms.ComboBox();
            this.btn_finish = new System.Windows.Forms.Button();
            this.lbl_status_title = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_days_title = new System.Windows.Forms.Label();
            this.lbl_mins_title = new System.Windows.Forms.Label();
            this.lbl_days = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_work_days_title = new System.Windows.Forms.Label();
            this.lbl_work_days = new System.Windows.Forms.Label();
            this.lbl_task_start_date_title = new System.Windows.Forms.Label();
            this.lbl_task_start_date = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_task_name_title
            // 
            this.lbl_task_name_title.AutoSize = true;
            this.lbl_task_name_title.Location = new System.Drawing.Point(12, 44);
            this.lbl_task_name_title.Name = "lbl_task_name_title";
            this.lbl_task_name_title.Size = new System.Drawing.Size(62, 13);
            this.lbl_task_name_title.TabIndex = 0;
            this.lbl_task_name_title.Text = "Task Name";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(315, 60);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(110, 23);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "Start working";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // cmb_projects
            // 
            this.cmb_projects.FormattingEnabled = true;
            this.cmb_projects.Location = new System.Drawing.Point(15, 60);
            this.cmb_projects.Name = "cmb_projects";
            this.cmb_projects.Size = new System.Drawing.Size(294, 21);
            this.cmb_projects.TabIndex = 2;
            this.cmb_projects.SelectedIndexChanged += new System.EventHandler(this.cmb_projects_SelectedIndexChanged);
            // 
            // btn_finish
            // 
            this.btn_finish.Location = new System.Drawing.Point(431, 60);
            this.btn_finish.Name = "btn_finish";
            this.btn_finish.Size = new System.Drawing.Size(110, 23);
            this.btn_finish.TabIndex = 3;
            this.btn_finish.Text = "Finish working";
            this.btn_finish.UseVisualStyleBackColor = true;
            this.btn_finish.Click += new System.EventHandler(this.btn_finish_Click);
            // 
            // lbl_status_title
            // 
            this.lbl_status_title.AutoSize = true;
            this.lbl_status_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status_title.Location = new System.Drawing.Point(312, 181);
            this.lbl_status_title.Name = "lbl_status_title";
            this.lbl_status_title.Size = new System.Drawing.Size(132, 24);
            this.lbl_status_title.TabIndex = 4;
            this.lbl_status_title.Text = "Current Status:";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ForeColor = System.Drawing.Color.Red;
            this.lbl_status.Location = new System.Drawing.Point(450, 181);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(109, 24);
            this.lbl_status.TabIndex = 5;
            this.lbl_status.Text = "NotWorking";
            // 
            // lbl_days_title
            // 
            this.lbl_days_title.AutoSize = true;
            this.lbl_days_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_days_title.Location = new System.Drawing.Point(312, 223);
            this.lbl_days_title.Name = "lbl_days_title";
            this.lbl_days_title.Size = new System.Drawing.Size(176, 24);
            this.lbl_days_title.TabIndex = 6;
            this.lbl_days_title.Text = "Total Days Elapsed:";
            // 
            // lbl_mins_title
            // 
            this.lbl_mins_title.AutoSize = true;
            this.lbl_mins_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mins_title.Location = new System.Drawing.Point(314, 310);
            this.lbl_mins_title.Name = "lbl_mins_title";
            this.lbl_mins_title.Size = new System.Drawing.Size(181, 24);
            this.lbl_mins_title.TabIndex = 7;
            this.lbl_mins_title.Text = "Work Time Elapsed:";
            // 
            // lbl_days
            // 
            this.lbl_days.AutoSize = true;
            this.lbl_days.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_days.ForeColor = System.Drawing.Color.Orange;
            this.lbl_days.Location = new System.Drawing.Point(494, 221);
            this.lbl_days.Name = "lbl_days";
            this.lbl_days.Size = new System.Drawing.Size(20, 24);
            this.lbl_days.TabIndex = 8;
            this.lbl_days.Text = "0";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_time.Location = new System.Drawing.Point(493, 310);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(20, 24);
            this.lbl_time.TabIndex = 9;
            this.lbl_time.Text = "0";
            // 
            // lbl_work_days_title
            // 
            this.lbl_work_days_title.AutoSize = true;
            this.lbl_work_days_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_work_days_title.Location = new System.Drawing.Point(314, 266);
            this.lbl_work_days_title.Name = "lbl_work_days_title";
            this.lbl_work_days_title.Size = new System.Drawing.Size(179, 24);
            this.lbl_work_days_title.TabIndex = 10;
            this.lbl_work_days_title.Text = "Work Days Elapsed:";
            // 
            // lbl_work_days
            // 
            this.lbl_work_days.AutoSize = true;
            this.lbl_work_days.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_work_days.ForeColor = System.Drawing.Color.RosyBrown;
            this.lbl_work_days.Location = new System.Drawing.Point(497, 266);
            this.lbl_work_days.Name = "lbl_work_days";
            this.lbl_work_days.Size = new System.Drawing.Size(20, 24);
            this.lbl_work_days.TabIndex = 11;
            this.lbl_work_days.Text = "0";
            // 
            // lbl_task_start_date_title
            // 
            this.lbl_task_start_date_title.AutoSize = true;
            this.lbl_task_start_date_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_task_start_date_title.Location = new System.Drawing.Point(314, 140);
            this.lbl_task_start_date_title.Name = "lbl_task_start_date_title";
            this.lbl_task_start_date_title.Size = new System.Drawing.Size(139, 24);
            this.lbl_task_start_date_title.TabIndex = 12;
            this.lbl_task_start_date_title.Text = "Task Start Date:";
            // 
            // lbl_task_start_date
            // 
            this.lbl_task_start_date.AutoSize = true;
            this.lbl_task_start_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_task_start_date.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_task_start_date.Location = new System.Drawing.Point(452, 140);
            this.lbl_task_start_date.Name = "lbl_task_start_date";
            this.lbl_task_start_date.Size = new System.Drawing.Size(100, 24);
            this.lbl_task_start_date.TabIndex = 13;
            this.lbl_task_start_date.Text = "01.01.1900";
            // 
            // EffortTrackerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_task_start_date);
            this.Controls.Add(this.lbl_task_start_date_title);
            this.Controls.Add(this.lbl_work_days);
            this.Controls.Add(this.lbl_work_days_title);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.lbl_days);
            this.Controls.Add(this.lbl_mins_title);
            this.Controls.Add(this.lbl_days_title);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_status_title);
            this.Controls.Add(this.btn_finish);
            this.Controls.Add(this.cmb_projects);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.lbl_task_name_title);
            this.Name = "EffortTrackerForm";
            this.Text = "Effort Tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_task_name_title;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.ComboBox cmb_projects;
        private System.Windows.Forms.Button btn_finish;
        private System.Windows.Forms.Label lbl_status_title;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_days_title;
        private System.Windows.Forms.Label lbl_mins_title;
        private System.Windows.Forms.Label lbl_days;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_work_days_title;
        private System.Windows.Forms.Label lbl_work_days;
        private System.Windows.Forms.Label lbl_task_start_date_title;
        private System.Windows.Forms.Label lbl_task_start_date;
    }
}

