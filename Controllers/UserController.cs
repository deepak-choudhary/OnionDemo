using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using OnionService.Service;
using OnionService.Data;
using Microsoft.AspNetCore.Http;
namespace OnionService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        
        [HttpGet]
        public IActionResult Index()
        {
            return Ok(_userService.GetUsers());
        }
    }
}