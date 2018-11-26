using AttendanceBot.Data;
using System.Web.Http;
using AttendanceBot.Models.Response;
using AttendanceBot.Helpers;

namespace AttendanceBot.Controllers
{
    public class ApiAiController : ApiController
    {
        public DialogFlowResponse Post(AiResponseV2 aiResponse)
        {
            //v2.0
            var repo = new AttendanceRepo();
            var student = repo.GetStudent(aiResponse.QueryResult.Parameters.StudentNumber);
            var commonModel = Handlers.AttendanceIntent.Process(
                CommonModelHelper.DialogFlowToCommonModel(aiResponse),
                student
            );
            return new DialogFlowResponse
            {
                FulfillmentText = commonModel.Response.Text,
                Source = commonModel.Response.Source
            };
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