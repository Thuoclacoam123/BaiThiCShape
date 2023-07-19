using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaithiC_
{
    internal class ProductDBContext :DbContext
    {
        public ProductDBContext(DbContextOptions<ProductDBContext> options)
        : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }

    }
}
