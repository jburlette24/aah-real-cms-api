using System;
using System.Collections.Generic;

namespace aah_real_cms_api.Domain.Models
{
    public class Post
    {
        public int PostId { get; set; }

        public DateTime PublicationDate { get; set; }

        public Author Author { get; set; }

        public int AuthorId { get; set; }


        public string Title { get; set; }

        public string Text { get; set; }

    }
}

