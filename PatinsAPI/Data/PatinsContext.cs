using Microsoft.EntityFrameworkCore;
using PatinsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatinsAPI.Data
{
    public class PatinsContext : DbContext
    {
        public PatinsContext(DbContextOptions<PatinsContext> opts) : base(opts) 
        {

        }

        public DbSet<Patins> Patins { get; set; }
    }
}
