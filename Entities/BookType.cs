namespace EF__automatic.Entities
{
    public class BookType:BaseEntity_1
    {
        public string? Name { get; set; }

        //Navigation Property
        public ICollection<Book>? Books { get; set; }
    }
}
