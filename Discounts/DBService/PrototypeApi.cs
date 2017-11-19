using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Discounts.DBModel;

namespace Discounts.PrototypeApi
{
    class PrototypeApi
    {
        public class ApiContext : DbContext
        {
            
            public ApiContext(DbContextOptions<ApiContext> options)
                : base(options)
            {

            }

            public DbSet<Item> Items { get; set; }

            public DbSet<ItemCategory> ItemCategory { get; set; }
        }
    }
}
