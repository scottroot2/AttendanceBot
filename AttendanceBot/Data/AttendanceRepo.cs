using AttendanceBot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AttendanceBot.Data
{
    public class AttendanceRepo
    {
        public void SaveData(Student student)
        {
            using (var db = new AttendanceContext())
            {
                db.Students.Add(student);
                db.SaveChanges();
            }
        }

        public List<Student> GetStudents()
        {
            List<Student> students;// = new List<Student>();
            using (var db = new AttendanceContext())
            {
                students = (from s in db.Students
                            select s).ToList<Student>() ;
            }
            return students;
        }
    }
}