namespace EF__automatic.Entities
{
    public class Author:BaseEntity_1
    {

        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public ICollection<Book>? Books { get; set; }
    }
}
