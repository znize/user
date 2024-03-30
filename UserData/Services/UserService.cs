using Microsoft.EntityFrameworkCore;
using UserData.Data;
using UserData.Models;

namespace UserData.Services
{
	public class UserService : IUserService
	{
		private readonly AppDbContext _dbContext;

		public UserService(AppDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public async Task<User> CreateUser(User user)
		{
			_dbContext.Users.Add(user);
			await _dbContext.SaveChangesAsync();
			return user;
		}

		public async Task<User?> GetUserByPersonlId(string personalId)
		{
			var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.PersonalId.Equals(personalId));
			return user;
		}
	}
}
