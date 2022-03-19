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
    public class IndexModel : PageModel
    {
        private readonly LicheeWeb.Data.LicheeWebContext _context;

        public IndexModel(LicheeWeb.Data.LicheeWebContext context)
        {
            _context = context;
        }

        public IList<Department> Department { get;set; }

        public async Task OnGetAsync()
        {
            Department = await _context.Department.ToListAsync();
        }
    }
}
