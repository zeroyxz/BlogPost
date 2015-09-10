using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using BlogPost.Models;

namespace BlogPost.DAL
{
    public class BlogContext:DbContext
    {
        public BlogContext() : base("BlogContent")
        {
            this.Database.Log = Console.Write;
        }
        //Because Blogs contains a reference to Posts it should handle both
        //But what if we want to use both Blogs and Posts?
        public DbSet<Blog> Blogs { get; set; }

        /*Even with just the Blogs entity defined both Blogs and Posts were created as database tables
        * The Id was created as an Identity column and strings are nvarchar(max) with A PKey on ID
        * An index was created on Posts against the BlogID 
        * A constraint was added to Posts for Foriegn Key referencing Blogs.Id Delete cascade
        * Lastly a table was added called __MigrationHistory and the first migration added
        */

        //With no separate Posts DBSet I guess all Post Manipulation must take place through a Blog instance

        //If you make changes you can either create a new migration or re-run the Add-Migration initial again

        //Update-Database calls the Seed method
        
    }
}