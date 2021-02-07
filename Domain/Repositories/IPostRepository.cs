using System.Collections.Generic;
using System.Threading.Tasks;
using aah_real_cms_api.Domain.Models;

namespace aah_real_cms_api.Domain.Repositories
{
    public interface IPostRepository
    {
        Task<IEnumerable<Post>> ListAsync();
    }

}