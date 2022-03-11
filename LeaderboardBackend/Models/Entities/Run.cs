using System.ComponentModel.DataAnnotations;

namespace LeaderboardBackend.Models.Entities;

public enum RunStatus
{
	Created,
	Submitted,
	Pending,
	Approved,
	Rejected
}

public class Run
{
	public Guid Id { get; set; }

	[Required]
	public DateTime Played { get; set; }

	[Required]
	public DateTime Submitted { get; set; }

	[Required]
	public RunStatus Status { get; set; }

	public List<Judgement>? Judgements { get; set; }	
}