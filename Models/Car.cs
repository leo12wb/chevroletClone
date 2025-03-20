namespace chevroletClone.Models
{
    public class Car
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Img { get; set; }
        public required string Mark { get; set; }
        public required string Description { get; set; }
        public decimal Price { get; set; }
    }
}
