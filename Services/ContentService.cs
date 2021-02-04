using System;
using System.Collections.Generic;
using aah_real_cms_api.Models;
using aah_real_cms_api.FakeData;

namespace aah_real_cms_api.Services
{
    public class ContentService
    {

        private readonly Data _data;

        public ContentService(Data data)
        {
            _data = data;
        }
        public List<Post> GetPosts()
        {
            return _data.FakePosts();
        }
    }
}