namespace BookVault.Model {
    public class Book {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public DateTime Published { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
