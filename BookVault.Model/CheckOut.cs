namespace BookVault.Model {
    public class CheckOut {
        public int BookId { get; set; }
        public string UserId { get; set; }
        public bool IsReturn { get; set; }
        public DateTime DueDate { get; set; }
        public Book Book { get; set; }
    }
}
