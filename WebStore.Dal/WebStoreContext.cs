using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebStore.Domain;
using WebStore.Domain.Entities;

namespace WebStore.Dal
{
    public class WebStoreContext : IdentityDbContext<User>
    {
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public WebStoreContext(DbContextOptions options) : base(options)
        {

        }
    }
}
