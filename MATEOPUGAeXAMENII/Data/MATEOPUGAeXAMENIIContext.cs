using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MATEOPUGAeXAMENII.Models;

namespace MATEOPUGAeXAMENII.Data
{
    public class MATEOPUGAeXAMENIIContext : DbContext
    {
        public MATEOPUGAeXAMENIIContext (DbContextOptions<MATEOPUGAeXAMENIIContext> options)
            : base(options)
        {
        }

        public DbSet<MATEOPUGAeXAMENII.Models.MPLIBRO> MPLIBRO { get; set; } = default!;
    }
}
