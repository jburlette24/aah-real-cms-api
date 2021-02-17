using System;

namespace aah_real_cms_api.Domain.DTOs
{
    public class PostDto
    {
        public int PostId { get; set; }

        public DateTime PublicationDate { get; set; }

        public AuthorDto Author { get; set; }


        public string Title { get; set; }

        public string Text { get; set; }

    }
}