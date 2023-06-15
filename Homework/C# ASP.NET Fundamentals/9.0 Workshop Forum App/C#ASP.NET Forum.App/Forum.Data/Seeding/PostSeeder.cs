using Forum.Data.Mode;

namespace Forum.App.Data.Seeding
{
     class PostSeeder
    {
        internal Post[] GeneratePosts()
        {
            ICollection<Post> posts = new HashSet<Post>();
            //Post currentPost;
            //currentPost = new Post()
            //{
            //    Title = "My first post",
            //    Content = "First Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin dictum metus nec magna auctor tincidunt. Fusce et dolor quis nunc."
            //};
            //posts.Add(currentPost);

            //currentPost = new Post()
            //{
            //    Title = "My second post",
            //    Content = "Second Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin ornare turpis ornare purus laoreet porta. Donec semper nibh maximus mauris eleifend, quis mattis nunc rutrum."
            //};
            //posts.Add(currentPost);

            //currentPost = new Post()
            //{
            //    Title = "My third post",
            //    Content = "Third Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent feugiat, nunc sit amet sagittis vestibulum, sem dolor lacinia leo."
            //};
            //posts.Add(currentPost);

            return posts.ToArray();
        }
     }
}
