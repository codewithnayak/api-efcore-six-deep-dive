using EFCoreDeepDive.Db.Seed;
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
        public DbSet<CinemaHall> CinemaHalls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<MovieActor> MovieActors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
           
        }

        /// <summary>
        /// This is the place where global conventions can be configured ,
        /// like all string lenghts are 200 for an example.
        /// </summary>
        /// <param name="configurationBuilder"></param>
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);
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
            MovieDbSeeder.Seed(modelBuilder);


        }
    }
}
