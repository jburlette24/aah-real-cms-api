using System;

namespace aah_real_cms_api.Domain.Models
{
    public class Author
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string FullName
        {
            get
            {
                return $"{Name} {Surname}";
            }
        }

        public string BioBlurb { get; set; }
    }
}
