using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using blogClassLibrary;

namespace blogConsoleApp
{
    class Program
    {
         private static void DisplayMenu()
         {
            Console.WriteLine("Blog in C#{0}", Environment.NewLine);
            Console.WriteLine("--------------------------------------------");
            // display nr of posts here, in the phranteses
            Console.WriteLine("################## Posts (0) ############### {0}", Environment.NewLine);
            Console.WriteLine("There are no posts to show at this moment");
            Console.WriteLine("--------------------------------------------{0}", Environment.NewLine);
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - Add a new post");
            Console.WriteLine("2 - Create a new account");
            Console.WriteLine("X - Exit");
        }

        private static void DisplayPosts()
        {
            foreach (Post post in )
        }

        static void Main(string[] args)
        {
            //DisplayMenu();
            IPostsService postsService = new PostsService();
            CommonBoard commonboard = new CommonBoard(postsService);

            //create post
            Post firstPost = AddPost("Orsi Sebestyen", "This is the content of the first post", new DateTime(2019, 01, 19));
            //create user
            User orsi = AddUser("elfromka@yahoo.co.uk", "Orsolya", "Sebestyen", new DateTime(1994, 01, 01));
            //showing/listing posts
            List<Post> posts = GetPosts();
        }
    }
}
