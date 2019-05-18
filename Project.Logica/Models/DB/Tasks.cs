﻿using ProjectCore.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectCore.Logica.Models.DB
{
    public class Tasks
    {

        public Tasks()
        {
            Projects = new Projects();
            Activities = new Activities();
            Priorities = new Priorities();
            States = new States();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public bool? IsCompleted { get; set; }
        public int? Effort { get; set; }
        public int? RemainingWork { get; set; }
        public int? StateId { get; set; }
        public int? ActivityId { get; set; }
        public int? PriorityId { get; set; }
        public int? ProjectId { get; set; }

        public Activities Activities { get; set; }
        public Priorities Priorities { get; set; }
        public Projects Projects { get; set; }
        public States States { get; set; }
    }
}
