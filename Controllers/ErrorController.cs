using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ErrorController : ControllerBase
    {
        //http://localhost:5182/not-found
        [HttpGet("not-found")]
        public IActionResult NotFoundError()
        {
            return NotFound(); // 300 status code
        }

        [HttpGet("bad-request")]
        public IActionResult BadRequestError()
        {
            return BadRequest(); //400 status code
        }

        [HttpGet("unauthorized")]
        public IActionResult UnAuthorizedError()
        {
            return Unauthorized(); //401 status code
        }
        
        [HttpGet("validation")]
        public IActionResult ValidationError()
        {
            ModelState.AddModelError("validation error1","validation error details");
            ModelState.AddModelError("validation error2","validation error details");
            return ValidationProblem();
        }
        [HttpGet("server-error")]
        public IActionResult ServerError()
        {
            throw new Exception("server error");
        }

    }
}