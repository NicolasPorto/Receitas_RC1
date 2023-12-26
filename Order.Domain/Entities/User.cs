using Order.Domain.Models;
using Order.Infra.Enums;

namespace Order.Domain.Entities
{
    public class User : EntityBase
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public Situation Situation { get; set; }
    }
}
