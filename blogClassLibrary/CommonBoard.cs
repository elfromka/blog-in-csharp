using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blogClassLibrary
{
    public class CommonBoard
    {
        private IPostsService postsService;

        private UsersService usersService;
        private PostsService postsService;

        public CommonBoard(IPostsService postsService)
        {
            this.usersService = new UsersService();
            this.postsService = new PostsService();
        }

        public Post AddPost(string author, string content, DateTime postDate)
        {
            return postsService.AddPost(author, content, postDate);
        }

        public IEnumerable<Post> GetPosts()
        {
            return postsService.GetPosts();
        }
    }
}
