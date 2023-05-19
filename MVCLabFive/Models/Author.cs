using System.ComponentModel.DataAnnotations;

namespace MVCLabFive.Models
{
    public class Author
    {
      
        public int AuthorId { get; set; }

        public string Name { get; set; }

        public virtual ICollection<BookAuthor> BookAuthor { get; set; } = new HashSet<BookAuthor>();
    }
}
