using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using aah_real_cms_api.Domain.Models;

namespace aah_real_cms_api.Domain.Services
{
    public interface IContentService
    {
        Task<IEnumerable<Post>> GetPosts();
    }
}