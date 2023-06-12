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
            Sucesso = true;
            Mensagem = string.Empty;
        }

        public ResponseBase(bool sucesso, string mensagem)
        {
            Sucesso = sucesso;
            Mensagem = mensagem;
        }

        public bool Sucesso { get; set; }
        public string Mensagem { get; set; }

        public void SetErroGenerico()
        {
            Sucesso = false;
            Mensagem = "Ocorreu um erro na requisição.";
        }

        public void SetErroTratado(RCException ex)
        {
            Sucesso = false;
            Mensagem = ex.Message;
        }


        public static TResponse ErroGenerico()
        {
            var response = Activator.CreateInstance<TResponse>();
            response.SetErroGenerico();
            return response;
        }

        public static TResponse ErroTratado(RCException spbEx)
        {
            var response = Activator.CreateInstance<TResponse>();
            response.SetErroTratado(spbEx);
            return response;
        }
    }
}
