using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blogClassLibrary
{
    public class Post
    {
        public int Id { get; private set; }

        public Post(int id, string author, string content, DateTime postDate):base(author, content, postDate)
        {
            this.Id = id;
        }
    }
}
