﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aah_real_cms_api.Models;
using aah_real_cms_api.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace aah_real_cms_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContentController : ControllerBase
    {

        private readonly ILogger<ContentController> _logger;
        private readonly ContentService _contentService;

        public ContentController(ILogger<ContentController> logger, ContentService contentService)
        {
            _logger = logger;
            _contentService = contentService;
        }

        [HttpGet]
        public List<Post> GetPosts()
        {
            _logger.Log(LogLevel.Debug, "hit contentService.getPosts");
            return _contentService.GetPosts();
        }
    }
}