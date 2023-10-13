using Deliveroo.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deliveroo.Data
{
    public class DeliverooContext : IdentityDbContext<User>
    {
        public DeliverooContext(DbContextOptions<DeliverooContext> options)
           : base(options)
        {
        }
        public DbSet<Deliveroo.Models.Category> Category { get; set; }
        public DbSet<Deliveroo.Models.Menu> Menu { get; set; }
        public DbSet<Deliveroo.Models.MenuItem> MenuItem { get; set; }
        public DbSet<Deliveroo.Models.Cart> Cart { get; set; }
        public DbSet<Deliveroo.Models.CartItem> CartItem { get; set; }
        public DbSet<Deliveroo.Models.Order> Order { get; set; }
        public DbSet<Deliveroo.Models.Restaurant> Restaurant { get; set; }
        public DbSet<Deliveroo.Models.Review> Review { get; set; }
        public DbSet<Deliveroo.Models.User> User { get; set; }
    }
}
