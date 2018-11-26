using AttendanceBot.Data;
using System.Web.Http;
using AttendanceBot.Models.Response;

namespace AttendanceBot.Controllers
{
    public class ApiAiController : ApiController
    {
        public dynamic Post(AiResponseV2 aIResponse)
        {
            //v2.0
            var repo = new AttendanceRepo();
            var student = repo.GetStudent(aIResponse.QueryResult.Parameters.StudentNumber);

            var response = new
            {
                fulfillmentText = $"Got it {student.FirstName}, thanks!",
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