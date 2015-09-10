using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogPost.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime DatePublished { get; set; }
        public string Author { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}