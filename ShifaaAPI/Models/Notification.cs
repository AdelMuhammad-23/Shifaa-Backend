﻿using System.ComponentModel.DataAnnotations.Schema;
using ShifaaAPI.Models.Identity;

namespace ShifaaAPI.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Message { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }

    }
}
