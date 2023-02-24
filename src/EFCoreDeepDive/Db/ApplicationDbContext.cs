using EFCoreDeepDive.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace EFCoreDeepDive.Db
{
    public class ApplicationDbContext : DbContext
    {
        /// <summary>
        /// Genre entity 
        /// </summary>
        public DbSet<Genre> Genres { get; set; }

        /// <summary>
        /// Actor Entity
        /// </summary>
        public DbSet<Actor> Actors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<Cinema> Cinemas { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<Movie> Movies { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
           
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            //TODO:Can be kept in a separate project , will do later 
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
