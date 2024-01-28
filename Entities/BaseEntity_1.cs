using EF__automatic.Enums;

namespace EF__automatic.Entities
{
    public abstract class BaseEntity_1
    {
        public int Id { get; set; }
        public DataStatus dataStatus { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public BaseEntity_1()
        {
            CreateDate = DateTime.Now;
        }
    }
}
