using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Mapping
/// </summary>
public class Mapping : DbContext
{
    static Mapping()
    {
        Database.SetInitializer<Mapping>(null);
    }
    private readonly string schema;
    public Mapping()
        : base("name=connect")
    {
        
    }
    public DbSet<E_user> votantes { get; set; }
    public DbSet<E_admin> user_admin { get; set; }
    public DbSet<E_candidato> candidato { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema(this.schema);
        base.OnModelCreating(modelBuilder);
    }
}