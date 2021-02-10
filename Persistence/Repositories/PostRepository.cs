using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aah_real_cms_api.Domain.Models;
using aah_real_cms_api.Domain.Repositories;
using aah_real_cms_api.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace aah_real_cms_api.Persistence.Repositories
{
    public class PostRepository : BaseRepository, IPostRepository{
        public PostRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<IEnumerable<Post>> ListAsync()
        {
            return await _context.Posts.ToListAsync();
        }
    }
}