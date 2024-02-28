using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoSalesMvc.Models;

namespace ProjetoSalesMvc.Data
{
    public class ProjetoSalesMvcContext : DbContext
    {
        public ProjetoSalesMvcContext (DbContextOptions<ProjetoSalesMvcContext> options)
            : base(options)
        {
        }

        public DbSet<ProjetoSalesMvc.Models.Department> Department { get; set; } = default!;
    }
}
