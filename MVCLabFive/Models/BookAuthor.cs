using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCLabFive.Models
{
    public class BookAuthor
    {
        [ForeignKey("Book")]
        public int BookId { get; set; }
        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public int? order { get; set; }

        public virtual Author Author { get; set; }
        public virtual Book Book { get; set; }
    }
}
