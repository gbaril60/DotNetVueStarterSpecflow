using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpecflowDotNetCoreVue.Services;

namespace SpecflowDotNetCoreVue.Features.Login
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly UserProfileService _service;

        public LoginController(UserProfileService service) 
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult LogIn(int salesId)
        {
            return Ok();
        }
    }
}