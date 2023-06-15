using System.ComponentModel.DataAnnotations;

namespace Forum.Data.Mode
{
    using static Forrum.Commen.Validations.EntityValidations.Post;
    public class Post
    {
        public Post()
        {
            this.Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        //[MinLength(TitleMinLength)]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; } = null!;

        [Required]
        //[MinLength(ContentMinLength)]
        [MaxLength(ContentMaxLength)]
        public string Content { get; set; } = null!;
    }
}
