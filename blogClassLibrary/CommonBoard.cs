using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blogClassLibrary
{
    public class CommonBoard
    {
        private UsersService usersService;
        private PostsService postsService;

        public CommonBoard()
        {
            this.usersService = new UsersService();
            this.postsService = new PostsService();
        }

        public Post AddPost(string author, string content, DateTime postDate)
        {
            return postsService.AddPost(author, content, postDate);
        }
    }
}
