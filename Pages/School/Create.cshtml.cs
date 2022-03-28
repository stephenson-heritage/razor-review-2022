#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using razor_review.Models;

namespace razor_review.Pages.School
{
	public class CreateModel : PageModel
	{
		private readonly DBContext _context;

		public CreateModel(DBContext context)
		{
			_context = context;
		}

		public IActionResult OnGet()
		{
			return Page();
		}

		[BindProperty]
		public razor_review.Models.School School { get; set; }

		// To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
		public async Task<IActionResult> OnPostAsync()
		{
			if (!ModelState.IsValid)
			{
				return Page();
			}

			_context.School.Add(School);
			await _context.SaveChangesAsync();

			return RedirectToPage("./Index");
		}
	}
}
