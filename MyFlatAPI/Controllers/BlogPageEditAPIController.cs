using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFlatAPI.Data;
using MyFlatAPI.Data.Models.Rendering;

namespace MyFlatAPI.Controllers
{
    public class BlogPageEditAPIController : Controller
    {
        private DataManager _dataManager;

        public BlogPageEditAPIController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }

        [HttpGet("[controller]/GetPostsFromDB")]
        public List<PostModel> GetPostsFromDB()
        {
            return _dataManager.PageEditor.GetPostsFromDB();
        }

        [HttpPost("[controller]/AddPostToDB/{PostModel?}")]
        public bool AddPostToDB([FromBody] PostModel model)
        {
            return _dataManager.PageEditor.AddPostToDB(model);
        }

        [HttpGet("[controller]/GetPostById/{id?}")]
        public PostModel GetPostById(int id)
        {
            var post = _dataManager.PageEditor.GetPostById(id);
            return post;
        }

        [HttpPost("[controller]/ChangePost/{PostModel?}")]
        public bool ChangePost([FromBody] PostModel model)
        {
            return _dataManager.PageEditor.ChangePost(model);
        }

        [HttpPost("[controller]/DeletePostById/{id?}")]
        public bool DeletePostById(int id)
        {
            return _dataManager.PageEditor.DeletePostById(id);
        }
    }
}
