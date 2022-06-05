using System;
using Microsoft.EntityFrameworkCore;
using SixApi.Models;

namespace SixApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Command> commands => Set<Command>();
        public DbSet<Platform> platforms => Set<Platform>();
    }

}