using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookVault.Model {
    public class EventReview {
        public int EventReviewId { get; set; }
        public string UserId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public int EventId { get; set; }
        public Event Event { get; set; }
    }
}
