using Order.Application.Messaging.Api;

namespace Order.Application.DataContract.Response.User
{
    public class UserResponse : ResponseBase
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
    }
}