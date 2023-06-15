using System.ComponentModel.DataAnnotations;
using static System.Reflection.Metadata.BlobBuilder;


namespace Library.Data.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = null!;

        public HashSet<Book> Books { get; set; } = new HashSet<Book>();
    }
}
