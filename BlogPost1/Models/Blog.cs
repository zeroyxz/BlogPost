using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogPost.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Owner { get; set; }
        public List<Post> Posts { get; set; }
    }
}