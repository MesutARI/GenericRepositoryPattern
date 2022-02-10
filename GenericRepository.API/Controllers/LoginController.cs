using AutoMapper;
using GenericRepository.Core.UnitOfWorks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepository.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        #region variables

        #endregion

        #region CategoriesController
        public LoginController()
        {
            
        }
        #endregion


        // api/Login
        [HttpGet]
        public ActionResult Get()
        {
            return Ok("Generic Repository API Started...");
        }
        
    }
}
