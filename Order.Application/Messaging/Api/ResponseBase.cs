using Order.Infra.Exceptions;

namespace Order.Application.Messaging.Api
{
    [Serializable]
    public class ResponseBase : ResponseBase<ResponseBase>
    {
    }

    [Serializable]
    public class ResponseBase<TResponse> where TResponse : ResponseBase<TResponse>
    {
        public ResponseBase()
        {
            Success = true;
            Message = string.Empty;
        }

        public ResponseBase(bool success, string message)
        {
            Success = success;
            Message = message;
        }

        public bool Success { get; set; }
        public string Message { get; set; }

        public void SetGenericError()
        {
            Success = false;
            Message = "Unknown error.";
        }

        public void SetErrorHandled(RCException ex)
        {
            Success = false;
            Message = ex.Message;
        }

        public static TResponse GenericError()
        {
            var response = Activator.CreateInstance<TResponse>();
            response.SetGenericError();
            return response;
        }

        public static TResponse ErrorHandled(RCException ex)
        {
            var response = Activator.CreateInstance<TResponse>();
            response.SetErrorHandled(ex);
            return response;
        }
    }
}
