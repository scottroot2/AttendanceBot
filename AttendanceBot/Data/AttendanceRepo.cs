using AttendanceBot.Models;
using System.Collections.Generic;
using System.Linq;

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

        public void AddStudentRoster(List<Student> students)
        {
            using (var db = new AttendanceContext())
            {
                db.Students.AddRange(students);
                db.SaveChanges();
            }
        }

        public List<Student> GetStudents()
        {
            List<Student> students;
            using (var db = new AttendanceContext())
            {
                students = (from s in db.Students
                            select s).ToList<Student>() ;
            }
            return students;
        }

        public Student GetStudent(string studentNumber)
        {
            using (var db = new AttendanceContext())
            {
                var student = (from s in db.Students
                        select s).Where(stud => stud.StudentId.Equals(studentNumber)).FirstOrDefault<Student>() ;

                return student;
            }
        }
    }
}