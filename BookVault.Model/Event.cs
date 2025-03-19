namespace BookVault.Model {
    public class Event {
        public int EventId { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public ICollection<EventReview> EventReviews { get; set; }
    }
}