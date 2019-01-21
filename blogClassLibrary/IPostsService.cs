using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blogClassLibrary
{
    public interface IPostsService
    {
        Post AddPost(string author, string content, DateTime postDate);
        List<Post> GetPosts();
    }
}