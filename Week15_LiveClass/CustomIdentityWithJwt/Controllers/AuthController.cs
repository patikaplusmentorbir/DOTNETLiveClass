using CustomIdentityWithJwt.Dtos;
using CustomIdentityWithJwt.Jwt;
using CustomIdentityWithJwt.Models;
using CustomIdentityWithJwt.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomIdentityWithJwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    // Authentication and Authorization
    //(Kimlik Belirleme ve Yetkilendirme)
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;

        public AuthController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterRequest request)
        {
            var userDto = new UserAddDto
            {
                Email = request.Email.Trim(),
                Password = request.Password
            };

            var result = await _userService.AddUser(userDto);

            if (result.IsSucceed)
                return Ok(result.Message);

            return BadRequest();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequest request)
        {
            var loginUserDto = new LoginUserDto
            {
                Email = request.Email,
                Password = request.Password
            };

            var result = await _userService.LoginUser(loginUserDto);

            if (!result.IsSucceed)
                return BadRequest();

            var user = result.Data;

            var configuration = HttpContext.RequestServices.GetRequiredService<IConfiguration>();

            var token = JwtHelper.GenerateJwt(new JwtInfo
            {
                Id = user.Id,
                Email = user.Email,
                UserType = user.UserType,
                SecretKey = configuration["Jwt:SecretKey"]!,
                Issuer = configuration["Jwt:Issuer"]!,
                Audience = configuration["Jwt:Audience"]!,
                ExpireMinutes = int.Parse(configuration["Jwt:ExpireMinutes"]!)



            });

            return Ok( new LoginResponse
            {
                Message = result.Message,
                Token = token
            });

        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult TestAdmin()
        {
            var userId = User.FindFirst("Id")?.Value;
            var userEmail = User.FindFirst("Email")?.Value;  
                
                return Ok($"TestAdmin end-point cevabı: Adminsiniz. - Id:{userId} - Email: {userEmail}");
        }

        
    }
}
