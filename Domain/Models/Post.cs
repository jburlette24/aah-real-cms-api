using System;
using System.Collections.Generic;

namespace aah_real_cms_api.Domain.Models
{
    public class Post
    {
        public Guid Id { get; set; }
        public DateTime PublicationDate { get; set; }

        public List<Author> Authors { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }


    }
}

