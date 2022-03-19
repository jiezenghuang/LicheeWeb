#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LicheeWeb.Models;

namespace LicheeWeb.Data
{
    public class LicheeWebContext : DbContext
    {
        public LicheeWebContext (DbContextOptions<LicheeWebContext> options)
            : base(options)
        {
        }

        public DbSet<LicheeWeb.Models.Position> Position { get; set; }

        public DbSet<LicheeWeb.Models.Department> Department { get; set; }

        public DbSet<LicheeWeb.Models.Staff> Staff { get; set; }

        public DbSet<LicheeWeb.Models.Project> Project { get; set; }

        public DbSet<LicheeWeb.Models.Mission> Mission { get; set; }
    }
}
