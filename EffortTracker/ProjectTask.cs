﻿
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace EffortTracker
{
    public class JsonRoot
    {
        public IEnumerable<ProjectTask> ProjectTasks { get; set; }
    }

    public class ProjectTask
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int TotalDaysElapsed { get; set; }

        public int TotalMinsElapsed { get; set; }

        public int WorkDaysElapsed { get; set; }

        public string LastWorkStartDateTime { get; set; }

        public ProjectStatus Status { get; set; }

        [JsonIgnore]
        public DateTime CurrentWorkStartDateTime { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }


    public enum ProjectStatus
    {
        NotWorking,
        Working
    }
}