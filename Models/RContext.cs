using Microsoft.EntityFrameworkCore;
using MvcRelations.Models;

namespace MvcRelations
{
    /// <summary>
    /// This class handles the sqlite database
    /// </summary>
    public class MvcRelationsContext : DbContext
    {
        // public DbSet<TodoItemModel> TestItems {get; set;}
        public DbSet<Node> Nodes {get; set;}
        public DbSet<Edge> Edges {get; set;}

       public MvcRelationsContext(DbContextOptions<MvcRelationsContext> options) : base(options){
           
       }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            // Specify the path of the database here
            optionsBuilder.UseSqlite("Filename=./relationsDB.db");
        }

    }
}