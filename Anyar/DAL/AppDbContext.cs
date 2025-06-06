﻿using Anyar.Models;
using Microsoft.EntityFrameworkCore;

namespace Anyar.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Employer> Employers { get; set; }

    }
}
