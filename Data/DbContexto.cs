using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Entity.Models;

    public class DbContexto : DbContext
    {
        public DbContexto (DbContextOptions<DbContexto> options)
            : base(options)
        {
        }

        public DbSet<Entity.Models.Cliente> Cliente { get; set; } = default!;
    }
