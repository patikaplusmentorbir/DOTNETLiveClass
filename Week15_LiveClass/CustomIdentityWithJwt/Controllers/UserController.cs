using CustomIdentityWithJwt.Dtos;
using CustomIdentityWithJwt.Models;
using CustomIdentityWithJwt.Services;
using Microsoft.AspNetCore.Mvc;

namespace CustomIdentityWithJwt.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserServiceV2 _userService;

        public UserController(IUserServiceV2 userService)
        {
            _userService = userService;
        }
        public IActionResult Create(AddUserRequest request)
        {
            var user = new UserAddDto
            {
                Email = request.Email,
                Password = request.Password,
            };

            _userService.AddUser(user);

            return Ok("Kullanıcı eklendi.");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _userService.DeleteUser(id);

            return Ok("Silindi");
        

        }
    }
}
