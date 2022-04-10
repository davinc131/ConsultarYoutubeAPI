using Dommain.Entidades.CanalHost;
using Dommain.Entidades.Comum;
using Dommain.Entidades.VideoHost;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
  public class Context : DbContext
  {
    public Context(DbContextOptions<Context> options) : base(options) 
    {
      this.Database.EnsureCreated();
    }

    public DbSet<ConsultaCanal> Canais { get; set; }
    public DbSet<ConsultaVideo> Videos { get; set; }
    public DbSet<CanalRoot> CanalRoot { get; set; }
    public DbSet<VideoRoot> VideoRoot { get; set; }
    public DbSet<Default> Default { get; set; }
    public DbSet<High> High { get; set; }
    public DbSet<Medium> Medium { get; set; }
    public DbSet<Snippet> Snippet { get; set; }
    public DbSet<Id> Id { get; set; }
    public DbSet<Item> Item { get; set; }
    public DbSet<PageInfo> PageInfo { get; set; }
    public DbSet<Thumbnails> Thumbnails { get; set; }
  }
}
