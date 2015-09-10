namespace BlogPost.Migrations
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;

    internal sealed class Configuration : DbMigrationsConfiguration<BlogPost.DAL.BlogContext>
    {
        public Configuration()
        {
            //note if we had specified Enable-Migrations -EnableAutomaticMigrations then a CodeFile for each Migration
            //would not be created.  We just call Update-Database and any changes will be made to the Db.  At any time though
            //we can call Add-Migration <Migrationname>  to create a
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BlogPost.DAL.BlogContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            //For seeding purposes only we will not allow Posts to have the same Title - this is not necessarily the case in live
            List<Post> posts1 = new List<Post>() {
                new Post {Title="When I was born", Author="Peter Worlin", Content="I was boen on 14th May 1970", DatePublished=DateTime.Now},
                new Post {Title="My Children", Author="Clare Worlin", Content="Lauren & Sophie", DatePublished=DateTime.Now.AddMonths(-1)}
            };


            List<Post> posts2 = new List<Post>()
            {
                new Post() {Author="Peter Worlin", Title="My Athletic Career", DatePublished=DateTime.Now.AddDays(-4),Content="IM Wales was my first full distance Tri" },
                new Post() {Author="Peter Worlin", Title="IM Wales", DatePublished = DateTime.Now.AddYears(-1), Content="Completed in just over 13 hours" }
            };

            context.Blogs.AddOrUpdate(
                b => b.Title,
                new Blog { Owner = "Peter Worlin", Title = "A step in time", Posts = posts2 },
                new Blog { Owner = "Peter Worlin", Title = "Family life", Posts = posts1 }
                );
        }
    }
}
