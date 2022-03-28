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
	public class IndexModel : PageModel
	{
		private readonly DBContext _context;

		public IndexModel(DBContext context)
		{
			_context = context;
		}

		public IList<razor_review.Models.School> School { get; set; }

		public async Task OnGetAsync()
		{
			School = await _context.School.ToListAsync();
		}
	}
}
