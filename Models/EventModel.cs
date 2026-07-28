namespace EventEase.Models
{
    public class EventModel
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Category { get; set; } = string.Empty;

        public string Location { get; set; } = string.Empty;

        public DateTime Date { get; set; }

        public string ImageUrl { get; set; } = string.Empty;

        public int Capacity { get; set; }

        public int RegisteredCount { get; set; }

        public bool IsFeatured { get; set; }
    }
}
