
namespace razor_review.Models;


public class School
{
	public int SchoolId { get; set; }
	public string? Name { get; set; }
	// address

	public virtual ICollection<Class>? AvailableClasses { get; set; }
	public int? StreetNumber { get; set; }
	public string? StreetName { get; set; }
	public string? PostalCode { get; set; }
	public string? City { get; set; }
	public string? Province { get; set; }
	public string? Phone { get; set; }


}