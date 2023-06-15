using Forum.App.Data.Seeding;
using Forum.Data.Mode;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Forum.App.Data.Configuration
{
    public class PostEntityConfoguration : IEntityTypeConfiguration<Post>
    {
        private readonly PostSeeder postSeeder;
        public PostEntityConfoguration()
        {
            this.postSeeder = new PostSeeder();
        }
        public void Configure(EntityTypeBuilder<Post> builder)
        {          
            builder.HasData(this.postSeeder.GeneratePosts());
        }
    }
}
