using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebAppPB01Lab1_AVR.Models
{
    public class Cliente_Context : DbContext
    {
        public Cliente_Context (DbContextOptions<Cliente_Context> options)
            : base(options)
        {
        }

        public DbSet<WebAppPB01Lab1_AVR.Models.Cliente> Cliente { get; set; }
    }
}
