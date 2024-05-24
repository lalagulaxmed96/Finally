using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourLogo.Core.Models;

namespace YourLogo.Data.DAL;

public class AppDbContext : DbContext
{
    public AppDbContext( DbContextOptions options) : base(options) { }


    public DbSet<Project> Projects { get; set;  }
}
