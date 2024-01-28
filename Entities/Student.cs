using EF__automatic.Enums;

namespace EF__automatic.Entities
{
    public class Student:BaseEntity_1
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int SchoolNumber { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDay { get; set; }
        public string? PhoneNumber { get; set; }


        //Navigation Property
        public ICollection<Book>? Books { get; set; }
    }
}
