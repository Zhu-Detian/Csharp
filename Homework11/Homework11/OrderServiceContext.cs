using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    public class OrderServiceContext : DbContext
    {
        public OrderServiceContext() : base("OrderDataBase")
        {
            Database.SetInitializer(
            new DropCreateDatabaseIfModelChanges<OrderServiceContext>());
        }

        public DbSet<DB_Order> Orders { get; set; }
        public DbSet<DB_OrderItem> Items { get; set; }
    }
}
