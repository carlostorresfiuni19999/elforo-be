using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using CursoIdentity.Helpers;
using elforo_be.Models;
using elforo_be.Models.dto;
using elforo_be.Models.ent;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace elforo_be.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase 
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<User> _userManager;
        private readonly IConfiguration _configuration;
        public AccountController
        (
            ApplicationDbContext db, 
            UserManager<User> userManager,
            IConfiguration conf
        )
        {
            _db = db;
            _userManager = userManager;
            _configuration = conf;
        }

        [Route("login")]
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> LogIn(UserLogin user)
        {
            if (ModelState.IsValid)
            {
                var User = _userManager.Users.FirstOrDefault(u => u.Email.Equals(user.Email));



                if (User == null) return NotFound();
                
              
                if (!await _userManager.CheckPasswordAsync(User, user.Password)) return BadRequest("Credenciales no validas");

                var UserRoles = await _userManager.GetRolesAsync(User);

                var authClaims = new List<Claim>
                {
                   new Claim(ClaimTypes.Name, User.UserName),
                   new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())

                };

                foreach (var userRole in UserRoles)
                {
                        authClaims.Add(new Claim(ClaimTypes.Role, userRole.ToString()));
                }

                var token = new TokenGenerator(_configuration);

                var tokenValues = token.GetToken(authClaims);
                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(tokenValues),
                    expiration = tokenValues.ValidTo,
                    email = User.Email,
                    roles = await _userManager.GetRolesAsync(User),
                    user = $"{User.Nombre} {User.Apellido}",
                    ingreso = User.Ingreso.ToString()
                }) ;
            }
            else
            {
                return BadRequest("Login no valido");
            }
        }
    }

}