namespace SNAPI.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using SNAPI.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<SNAPI.Models.SNAPIContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "SNAPI.Models.SNAPIContext";
        }

        protected override void Seed(SNAPI.Models.SNAPIContext context)
        {
            context.Posts.AddOrUpdate(x => x.Id,
                new Post() { Id = 1, Username = "jam", Content = "Test post 1234567 this is some test data to allow display of posts on the website" },
                new Post() { Id = 2, Username = "tubby", Content = "Test post 1234567 this is some test data to allow display of posts on the website" }
               );

            context.Headings.AddOrUpdate(x => x.Id,
                new Heading() { Id = 1, Text = "test", URL = "www.google.co.uk" });
        }
    }
}
