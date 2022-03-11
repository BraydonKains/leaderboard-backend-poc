namespace LeaderboardBackend.Controllers.Requests;

public record LoginRequest
{
	public string Email { get; set; } = null!;
	public string Password { get; set; } = null!;
}

public record LoginResponse
{
	public string Token { get; set; } = null!;
}
