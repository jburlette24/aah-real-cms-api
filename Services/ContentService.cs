using System;
using System.Collections.Generic;
using aah_real_cms_api.Models;

namespace aah_real_cms_api.Services
{
    public class ContentService : IContentService
    {
        public List<Post> GetPosts()
        {
            var jim = new Author
            {
                Name = "Jim",
                Surname = "Burlette",
                BioBlurb = "Jim is a cool cat born on the shores of the Connecticut River..."
            };
            
            var authors = new List<Author>(){jim};

            return new List<Post>()
            {
                new Post()
                {
                    Date = DateTime.Parse("05/22/1987"),
                    Authors = authors,
                    Title = "First Post",
                    Text = "This is my first Post"
                },
                new Post() {
                    Date = DateTime.Parse("06/22/1984"),
                    Authors = authors,
                    Title = "First Post",
                    Text = "This is my Second Post"
                }
            };

        }


    }
}