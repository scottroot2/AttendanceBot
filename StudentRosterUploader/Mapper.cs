using AttendanceBot.Helpers;
using AttendanceBot.Models;

namespace StudentRosterUploader
{
    public class Mapper
    {
        public static Student MapInputFileLineToStudent(string line)
        {
            var lineSegments = line.Split(';');
            var studentID = lineSegments[1];
            var fullName = lineSegments[3].Split(',');
            var firstName = fullName[1];
            var lastName = fullName[0];
            return new Student
            {
                FirstName = firstName,
                LastName = lastName,
                StudentId = studentID
            };
        }
    }
}