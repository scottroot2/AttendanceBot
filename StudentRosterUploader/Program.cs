using AttendanceBot.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace StudentRosterUploader
{
    class Program
    {
        static void Main(string[] args)
        {
            LoadFileToDB();
            Console.ReadLine();
        }

        private static void LoadFileToDB()
        {
            List<Student> students = new List<Student>();
            try
            {
                //TODO: Take path from command line
                using (StreamReader sr = new StreamReader("C:\\dev\\AttendanceBot\\StudentRosterUploader\\Files\\CSC210Fall2018Roster.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        students.Add(Mapper.MapInputFileLineToStudent(line));
                    }
                    
                }
                AttendanceBot.Data.AttendanceRepo repo = new AttendanceBot.Data.AttendanceRepo();
                repo.AddStudentRoster(students);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Could not read the file." + ex.ToString());
            }
        }
    }
}
