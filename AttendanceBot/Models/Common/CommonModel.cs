using System.Collections.Generic;

namespace AttendanceBot.Models.Common
{
    public class CommonModel
    {
        //public string Id { get;  set; }
        //internal Session Session { get; private set; }
        internal Request Request { get; private set; }
        internal Response Response { get; private set; }

        public CommonModel()
        {
            //Id = "";
           // Session = new Session();
            Request = new Request();
            Response = new Response();
        }

        
    }

    internal class Request
    {
        public string Id { get; set; }
        public string Intent { get; set; }
        //public List<KeyValuePair<string,string>> Parameters { get; set; }
        //public KeyValuePair<string,string> Parameter { get; set; }
        public string StudentNumber { get; set; }
    }

    internal class Response
    {
        public string Text { get; set; }
        public string Source { get; set; }
    }

    internal class Session
    {
        public string Id { get; set; }
    }
}