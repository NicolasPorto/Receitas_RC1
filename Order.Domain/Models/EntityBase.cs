namespace Order.Domain.Models
{
    public abstract class EntityBase
    {
        public Guid Codigo { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
