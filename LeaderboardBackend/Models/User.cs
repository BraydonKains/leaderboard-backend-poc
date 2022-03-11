using System.ComponentModel.DataAnnotations;

namespace LeaderboardBackend.Models;

public class User
{
	public Guid Id { get; set; }

	[Required] 
	public string Username { get; set; } = null!;

	[Required] 
	public string Email { get; set; } = null!;

	[Required] 
	public string Password { get; set; } = null!;

	public override bool Equals(object? obj)
	{
		return obj is User user &&
			   Id.Equals(user.Id) &&
			   Username == user.Username &&
			   Email == user.Email;
	}

	public override int GetHashCode()
	{
		return HashCode.Combine(Id, Username, Email);
	}
}
