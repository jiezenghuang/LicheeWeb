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

namespace LicheeWeb.Pages.Missions
{
    public class DeleteModel : PageModel
    {
        private readonly LicheeWeb.Data.LicheeWebContext _context;

        public DeleteModel(LicheeWeb.Data.LicheeWebContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Mission Mission { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Mission = await _context.Mission.FirstOrDefaultAsync(m => m.Id == id);

            if (Mission == null)
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

            Mission = await _context.Mission.FindAsync(id);

            if (Mission != null)
            {
                _context.Mission.Remove(Mission);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
