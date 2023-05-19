using System.ComponentModel.DataAnnotations.Schema;

namespace MVCLabFive.Models
{
    public class Review
    {
        public int reviewId { get; set; }
        public string voterName { get; set; }
        public int NumStars { get; set; }
        public string comment { get; set; }
        [ForeignKey("Book")]
        public int BookId { get; set; }
        public virtual Book Book { get; set; }
    }

}
