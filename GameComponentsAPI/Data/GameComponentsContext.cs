using Microsoft.EntityFrameworkCore;
using GameComponentsAPI.Models;
using System.Collections.Generic;

namespace GameComponentsAPI.Data
{
    public class GameComponentsContext : DbContext
    {
        public GameComponentsContext(DbContextOptions<GameComponentsContext> options)
            : base(options)
        {
        }

        public DbSet<Component> Components { get; set; }
    }
}
