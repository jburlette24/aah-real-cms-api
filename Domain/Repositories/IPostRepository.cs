using System.Collections.Generic;
using System.Threading.Tasks;
using aah_real_cms_api.Domain.DTOs;

namespace aah_real_cms_api.Domain.Repositories
{
    public interface IPostRepository
    {
        Task<List<PostDto>> ListAsync();
    }

}