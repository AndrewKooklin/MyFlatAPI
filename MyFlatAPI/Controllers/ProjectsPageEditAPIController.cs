﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFlatAPI.Data;
using MyFlatAPI.Data.Models.Rendering;

namespace MyFlatAPI.Controllers
{
    public class ProjectsPageEditAPIController : Controller
    {
        private DataManager _dataManager;

        public ProjectsPageEditAPIController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }

        [HttpGet("[controller]/GetProjectsFromDB")]
        public List<ProjectModel> GetProjectsFromDB()
        {
            return _dataManager.PageEditor.GetProjectsFromDB();
        }

        [HttpPost("[controller]/AddProjectToDB/{ProjectModel?}")]
        public bool AddProjectToDB([FromBody] ProjectModel model)
        {
            return _dataManager.PageEditor.AddProjectToDB(model);
        }

        [HttpGet("[controller]/GetProjectById/{id?}")]
        public ProjectModel GetProjectById(int id)
        {
            var project = _dataManager.PageEditor.GetProjectById(id);
            return project;
        }

        [HttpPost("[controller]/ChangeProject/{ProjectModel?}")]
        public bool ChangeProject([FromBody] ProjectModel model)
        {
            return _dataManager.PageEditor.ChangeProject(model);
        }

        [HttpPost("[controller]/DeleteProjectById/{id?}")]
        public bool DeleteProjectById(int id)
        {
            return _dataManager.PageEditor.DeleteProjectById(id);
        }
    }
}
