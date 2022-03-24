namespace ETicaretAPI.Domain.Entities.Common
{
    public class BaseEntity
    {
        public Guid ID { get; set; }
        public DateTime CreateDate { get; set; }
        public  DateTime UpdatedDate { get; set; }
    }
}
