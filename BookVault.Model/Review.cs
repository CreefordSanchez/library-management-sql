﻿namespace BookVault.Model {
    public class Review {
        public int ReviewId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
