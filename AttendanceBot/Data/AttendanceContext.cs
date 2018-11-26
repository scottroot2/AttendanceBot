using AttendanceBot.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AttendanceBot.Data
{
    public class AttendanceContext : DbContext
    {
        public AttendanceContext() : base("name=AttendanceDBContext")
        {

        }
        public DbSet<Student>  Students { get; set; }
        public DbSet<AttendanceSession> AttendanceSessions { get; set; }
    }
}