#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using razor_review.Models;

namespace razor_review.Pages.Student
{
	public class IndexModel : PageModel
	{
		private readonly DBContext _context;

		public IndexModel(DBContext context)
		{
			_context = context;
		}

		public IList<razor_review.Models.Student> Student { get; set; }

		public async Task OnGetAsync()
		{
			Student = await _context.Student.ToListAsync();
		}
	}
}
