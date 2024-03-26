using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HRMS.Models;

namespace HRMS.Data
{
    public class HRMSContext : DbContext
    {
        public HRMSContext (DbContextOptions<HRMSContext> options)
            : base(options)
        {
        }

        public DbSet<HRMS.Models.Employee> Employee { get; set; } = default!;
    }
}
