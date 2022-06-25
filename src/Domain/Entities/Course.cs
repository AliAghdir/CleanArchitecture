namespace Domain.Entities
{
    public class Course:BaseEntity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}