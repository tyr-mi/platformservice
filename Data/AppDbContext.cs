﻿using Microsoft.EntityFrameworkCore;
using platformservice.Models;

namespace platformservice.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {

        }

        public DbSet<Platform> Platforms { get; set; }

    }
}
