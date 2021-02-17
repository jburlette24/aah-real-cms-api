using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using aah_real_cms_api.Domain.Models;
using aah_real_cms_api.Domain.Repositories;
using System.Linq;
using aah_real_cms_api.Domain.DTOs;

namespace aah_real_cms_api.Domain.Services
{
    public class ContentService : IContentService
    {
        private readonly IPostRepository _postRepository;

        public ContentService(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task<List<PostDto>> GetPosts()
        {   
            var posts =  await _postRepository
            .ListAsync();

            return posts;
        }


    }
}