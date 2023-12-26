namespace Order.Domain.Models
{
    public abstract class EntityBase
    {
        public Guid Code { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
