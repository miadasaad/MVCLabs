using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCLabFive.Models
{
    public class PriceOffers
    {
        [Key]
        public int priceofferId { get; set; }
        public int newPrice { get; set; }
        public string promotionText { get; set; }

        [ForeignKey("Book")]
        public int BookId { get; set; }
        public virtual Book Book { get; set; }
    }
}
