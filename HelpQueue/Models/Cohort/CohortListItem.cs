﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelpQueue.Models.Cohort
{
    public class CohortListItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StudentCount { get; set; }
        public int QuestionCount { get; set; }
    } 
}