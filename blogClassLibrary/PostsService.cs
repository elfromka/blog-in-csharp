using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blogClassLibrary
{
    internal class PostsService
    {
        private List<Post> posts;
        private int nextPostId = 1;

        public PostsService()
        {
            this.posts = new List<Post>();
        }

        public Post AddPost(string author, string content, DateTime postDate)
        {
            Post post = new Post(nextPostId++, author, content, postDate);
            this.posts.Add(post);
            return post;
        }

        public List<Post> GetPosts()
        {
            return this.posts;
        }
    }
}
