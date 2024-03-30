using Microsoft.AspNetCore.Mvc;
using UserData.Models;
using UserData.Services;

namespace UserData.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class UserController : ControllerBase
	{

		private readonly IUserService _userService;

		public UserController(IUserService userService)
		{
			_userService = userService;
		}

		// An end point to create a new user
		[HttpPost]
		public async Task<ActionResult<User>> Create(User user)
		{
			var result = await _userService.CreateUser(user);
			return Created("User was created.", result);
		}

		// An end point to get a user by personal id number.
		[HttpGet]
		public async Task<ActionResult<User>> GetByPersonalId(string personalId)
		{
			var result = await _userService.GetUserByPersonlId(personalId);
			if (result == null)
			{
				return NotFound();
			}

			return Ok(result);
		}
			



		// An end point to update a user.


		// An end point to delete a user. 




	}
}
