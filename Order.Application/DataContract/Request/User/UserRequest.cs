namespace Order.Application.DataContract.Request.User
{
    public sealed class UserRequest
    {
        public Guid Codigo { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
    }
}