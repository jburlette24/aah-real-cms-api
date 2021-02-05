using System;
using System.Collections.Generic;
using aah_real_cms_api.Models;

namespace aah_real_cms_api.Services
{
    public interface IContentService
    {
        List<Post> GetPosts();
    }
}