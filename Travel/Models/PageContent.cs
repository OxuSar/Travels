namespace Travel.Models
{
    public class PageContent
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string ImagePath { get; set; }
        public DateTime publishedDate { get; set; }
        public int pageId { get; set; }
        public Page Page { get; set; }
    }
}
