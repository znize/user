using UserData.Models;

namespace UserData.Services
{
	public interface IUserService
	{

		Task<User> CreateUser(User user);

		Task<User?> GetUserByPersonlId(string personalId);

	}
}
