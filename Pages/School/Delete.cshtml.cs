#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using razor_review.Models;

namespace razor_review.Pages.School
{
	public class DeleteModel : PageModel
	{
		private readonly DBContext _context;

		public DeleteModel(DBContext context)
		{
			_context = context;
		}

		[BindProperty]
		public razor_review.Models.School School { get; set; }

		public async Task<IActionResult> OnGetAsync(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			School = await _context.School.FirstOrDefaultAsync(m => m.SchoolId == id);

			if (School == null)
			{
				return NotFound();
			}
			return Page();
		}

		public async Task<IActionResult> OnPostAsync(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			School = await _context.School.FindAsync(id);

			if (School != null)
			{
				_context.School.Remove(School);
				await _context.SaveChangesAsync();
			}

			return RedirectToPage("./Index");
		}
	}
}
