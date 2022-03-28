#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using razor_review.Models;

namespace razor_review.Pages.School;
public class DetailsModel : PageModel
{
	private readonly DBContext _context;
	private readonly ILogger<DetailsModel> _logger;

	public DetailsModel(DBContext context, ILogger<DetailsModel> logger)
	{
		_logger = logger;
		_context = context;
	}

	public razor_review.Models.School School { get; set; }

	public async Task<IActionResult> OnGetAsync(int? id)
	{
		if (id == null)
		{
			return NotFound();
		}




		School = await _context.School.FirstOrDefaultAsync(m => m.SchoolId == id);


		// foreach (var cl in School.AvailableClasses)
		// {
		// 	_logger.Log(LogLevel.Information, cl.Name);
		// }


		if (School == null)
		{
			return NotFound();
		}
		return Page();
	}
}
