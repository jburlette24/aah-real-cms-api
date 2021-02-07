using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using aah_real_cms_api.Domain.Models;
using aah_real_cms_api.Domain.Repositories;

namespace aah_real_cms_api.Domain.Services
{
    public class ContentService : IContentService
    {
        private readonly IPostRepository _postRepository;

        public ContentService(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task<IEnumerable<Post>> GetPosts()
        {   
            return await _postRepository.ListAsync();
        }


    }
}