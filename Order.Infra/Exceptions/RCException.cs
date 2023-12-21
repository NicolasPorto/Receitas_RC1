using System.Net;

namespace Order.Infra.Exceptions
{
    public class RCException : Exception
    {
        public HttpStatusCode? HttpStatusCode { get; set; }
        public bool GeraEventLog { get; set; }

        public RCException(bool geraEventLog = false)
        {
            GeraEventLog = geraEventLog;
        }

        public RCException(string message, Exception innerException, bool geraEventLog = false) : base(message, innerException)
        {
            GeraEventLog = geraEventLog;
        }

        public RCException(string message, bool geraEventLog = false) : base(message)
        {
            GeraEventLog = geraEventLog;
        }

        public RCException(string message, HttpStatusCode statusCode, bool geraEventLog = false) : base(message)
        {
            GeraEventLog = geraEventLog;
            HttpStatusCode = statusCode;
        }
    }
}