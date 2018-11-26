using System;
using AttendanceBot.Models.Common;
using AttendanceBot.Helpers;
using AttendanceBot.Models;

namespace AttendanceBot.Handlers
{
    public class AttendanceIntent
    {
        internal static CommonModel Process(CommonModel commonModel, Student student)
        {
            
            commonModel.Response.Text = $"Glad you could make it, {student.FirstName}!";
            commonModel.Response.Source = "AttendanceBot";
            return commonModel;
        }

        
    }
}