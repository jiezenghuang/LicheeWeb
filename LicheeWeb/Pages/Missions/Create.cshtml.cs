#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LicheeWeb.Data;
using LicheeWeb.Models;

namespace LicheeWeb.Pages.Missions
{
    public class CreateModel : PageModel
    {
        private readonly LicheeWeb.Data.LicheeWebContext _context;

        public CreateModel(LicheeWeb.Data.LicheeWebContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Mission Mission { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Mission.Add(Mission);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
