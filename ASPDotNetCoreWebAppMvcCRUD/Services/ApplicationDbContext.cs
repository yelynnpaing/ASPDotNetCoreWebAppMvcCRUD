﻿using ASPDotNetCoreWebAppMvcCRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPDotNetCoreWebAppMvcCRUD.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
    }
}
