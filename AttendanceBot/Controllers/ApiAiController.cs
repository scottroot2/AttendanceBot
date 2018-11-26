using ApiAiSDK.Model;
using AttendanceBot.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AttendanceBot.Controllers
{
    public class ApiAiController : ApiController
    {
        public dynamic Post(AIResponse aIResponse)
        {
            //var response = new
            //{
            //    speech = "Hello API.AI",
            //    displayText = "Hello API.AI"
            //};

            //v2.0
            var response = new
            {
                fulfillmentText = "Hello API.AI from V2.0",
                source = "echo"
            };
            return response;
        }

        public string Get()
        {
            string output = "";
            
            var repo = new AttendanceRepo();
            //repo.SaveData(new Models.Student { StudentId = 121212, FirstName="Billy", LastName = "BoBob" });
            var students = repo.GetStudents();
            foreach (var student in students)
            {
                output += student.FirstName + " :: ";
            }
            return output;
            //return "Hello API.AI!";
        }
    }
}
