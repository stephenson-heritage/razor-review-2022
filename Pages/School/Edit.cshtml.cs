#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using razor_review.Models;

namespace razor_review.Pages.School
{
	public class EditModel : PageModel
	{
		private readonly DBContext _context;

		public EditModel(DBContext context)
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

		// To protect from overposting attacks, enable the specific properties you want to bind to.
		// For more details, see https://aka.ms/RazorPagesCRUD.
		public async Task<IActionResult> OnPostAsync()
		{
			if (!ModelState.IsValid)
			{
				return Page();
			}

			_context.Attach(School).State = EntityState.Modified;

			try
			{
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!SchoolExists(School.SchoolId))
				{
					return NotFound();
				}
				else
				{
					throw;
				}
			}

			return RedirectToPage("./Index");
		}

		private bool SchoolExists(int id)
		{
			return _context.School.Any(e => e.SchoolId == id);
		}
	}
}
