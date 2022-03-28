
namespace razor_review.Models;


public class Class
{
	public int ClassId { get; set; }
	public string? Name { get; set; }
	// address
	public virtual School? School { get; set; }

}