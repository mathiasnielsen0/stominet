using Core.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabaseAccess.Data;

public class Database : Microsoft.EntityFrameworkCore.DbContext
{
    public Database(DbContextOptions options) : base(options) { }

    public DbSet<Bruger> Bruger { get; set; }
    public DbSet<Stomi> Stomi { get; set; }
}