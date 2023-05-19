namespace MVCLabFive.Models
{
    public class Tags
    {
        public int TagsId { get; set; }
        public virtual ICollection<Book> Books { get; set; } = new HashSet<Book>();
    }
}
