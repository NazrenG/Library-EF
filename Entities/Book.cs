namespace EF__automatic.Entities
{
    public class Book:BaseEntity_1
    {
        public string? Name { get; set; }
        public int PageCount { get; set; }

        //Foreign Key
        public int AutorId { get; set; }
        public int BookTypeId { get; set; }

        //Navigation Property
        public Author? Author { get; set; }
        public ICollection<Student>? Students { get; set; }
        public BookType? BookType { get; set; }
    }
}
