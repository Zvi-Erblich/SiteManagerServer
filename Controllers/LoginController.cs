using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SiteManagerServer.Models;

namespace SiteManagerServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly SiteManagerContext _context;

        public LoginController(SiteManagerContext context)
        {
            _context = context;
        }

       
        // POST: api/Login
        [HttpPost]
        public async Task<ActionResult<bool>> Login(Login user)
        {
            var foundUser = await _context.Users
                .FirstOrDefaultAsync(x => x.Email == user.Email && x.Password == user.Password);

            if (foundUser == null)
            {
                return Ok(false);  
            }
            
            return Ok(true);
        }
        
    }
}
