using System.ComponentModel.DataAnnotations;

namespace UserData.Models
{
	public class User
	{
		[Key]
		public string PersonalId { get; set; }
		public string Name { get; set; }
		public string? Email { get; set; }
		public string? PhoneNumber { get; set; }

	}
}
