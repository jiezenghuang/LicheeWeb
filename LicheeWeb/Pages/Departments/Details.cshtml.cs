#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LicheeWeb.Data;
using LicheeWeb.Models;

namespace LicheeWeb.Pages.Departments
{
    public class DetailsModel : PageModel
    {
        private readonly LicheeWeb.Data.LicheeWebContext _context;

        public DetailsModel(LicheeWeb.Data.LicheeWebContext context)
        {
            _context = context;
        }

        public Department Department { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Department = await _context.Department.FirstOrDefaultAsync(m => m.Id == id);

            if (Department == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
