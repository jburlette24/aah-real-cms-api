using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aah_real_cms_api.Domain.Models;
using aah_real_cms_api.Domain.Repositories;
using aah_real_cms_api.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using aah_real_cms_api.Domain.DTOs;

namespace aah_real_cms_api.Persistence.Repositories
{
    public class PostRepository : BaseRepository, IPostRepository
    {
        public PostRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<List<PostDto>> ListAsync()
        {
            return await _context.Posts.Include(p => p.Author)
            .Select(post => new PostDto{
                PostId = post.PostId,
                Author = new AuthorDto {
                    Name = post.Author.Name,
                    Surname = post.Author.Surname,
                    FullName = post.Author.FullName,
                    BioBlurb = post.Author.BioBlurb
                },
                PublicationDate = post.PublicationDate,
                Title = post.Title,
                Text = post.Text
            })
            .ToListAsync();
        }
    }
}