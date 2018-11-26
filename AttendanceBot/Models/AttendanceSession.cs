using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AttendanceBot.Models
{
    [Table("AttendanceSessions")]
    public class AttendanceSession
    {
        public int ID { get; set; }
        public string AttendanceSessionDescription { get; set; }
        public List<Student> Students { get; set; }
        
    }
}