namespace Entities
{
    public class Blog : BaseEntity
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? PhotoUrl { get; set; }
        public DateTime PublishDate { get; set; }
        public int? BlogCategoryId { get; set; }
        public virtual BlogCategory? BlogCategory { get; set; }
    }
}
