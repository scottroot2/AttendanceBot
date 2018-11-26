using AttendanceBot.Models.Common;
using AttendanceBot.Models.Response;

namespace AttendanceBot.Helpers
{
    public class CommonModelHelper
    {
        //internal static CommonModel AlexaToCommonModel(SkillRequest skillRequest)

        internal static CommonModel DialogFlowToCommonModel(AiResponseV2 aiResponse)
        {
            var commonModel = new CommonModel();
            //{
            //    Id = aiResponse.ResponseId.ToString()
            //};

            //commonModel.Session.Id = aiResponse.Session;
            commonModel.Request.Intent = aiResponse.QueryResult.Intent.Name;
            commonModel.Request.StudentNumber = aiResponse.QueryResult.Parameters.StudentNumber;

            return commonModel;
        }

        //internal static SkillResponse CommonModelToAlexa(CommonModel commonModel) { }

        internal static dynamic CommonModelToDialogFlow(CommonModel commonModel)
        {
            return new
            {
                fulfillmentText = commonModel.Response.Text, //$"Got it {student.FirstName}, thanks!",
                source = "AttendanceBot"
            };
        }
    }
}