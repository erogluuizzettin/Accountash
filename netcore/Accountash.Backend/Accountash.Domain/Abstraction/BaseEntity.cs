namespace Accountash.Domain.Abstraction
{
    public abstract class BaseEntity  
    {
        public string Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
