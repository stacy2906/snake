﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.API.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsCompleted { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? DueDate { get; set; }
    }
}
