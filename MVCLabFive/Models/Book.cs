using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCLabFive.Models
{
    public class Book
    {
     
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PublishedOn { get; set; }
        public string Publisher { get; set; }
        public int price { get; set; }
        public string ImgUrl { get; set; }
        [ForeignKey("PriceOffers")]
        public int? OfferId { get; set; }
        public Book()
        {
            Reviews = new HashSet<Review>();
        }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<Tags> Tags { get; set; } = new HashSet<Tags>();
        public virtual ICollection<BookAuthor> BookAuthor { get; set; } = new HashSet<BookAuthor>();
        public virtual PriceOffers PriceOffers { get; set; }
    }
}
