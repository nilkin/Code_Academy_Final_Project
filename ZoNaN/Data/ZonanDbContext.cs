using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace ZoNaN.Data
{
    public class ZonanDbContext: DbContext
    {
        public ZonanDbContext(DbContextOptions<ZonanDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
        }
    }
}
