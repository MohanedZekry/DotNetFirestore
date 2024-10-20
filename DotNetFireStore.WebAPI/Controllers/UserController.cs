using DotNetFireStore.Application.IService.IUserService;
using DotNetFireStore.Domain.Entities;
using DotNetFireStore.WebAPI.Controllers.Common;
using Microsoft.AspNetCore.Mvc;

namespace DotNetFireStore.WebAPI.Controllers
{
    public class UserController : BaseController
    {

        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> GetAllUsers()
        {
            var users = await _userService.GetAllUsersAsync();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUserById(string id)
        {
            var user = await _userService.GetUserByIdAsync(id);
            if (user == null)
                return NotFound();

            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> AddUser([FromBody] User user)
        {
            await _userService.AddUserAsync(user);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(string id, [FromBody] User user)
        {
            user.ID = id;
            await _userService.UpdateUserAsync(user);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(string id)
        {
            await _userService.DeleteUserAsync(id);
            return Ok();
        }

    }
}
