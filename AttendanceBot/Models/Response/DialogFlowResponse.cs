using Newtonsoft.Json;

namespace AttendanceBot.Models.Response
{
    public class DialogFlowResponse
    {
        [JsonProperty("fulfillmentText")]
        public string FulfillmentText { get; set; }
        [JsonProperty("source")]
        public string Source { get; set; }
    }
}