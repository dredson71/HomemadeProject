using Microsoft.EntityFrameworkCore;

 namespace Uweek.Models
 {
     public class ApplicationDbContext : DbContext
     {

        public DbSet<Person> Persons {get;set;}
        public DbSet<Author> Authors {get;set;}
        public DbSet<Song> Songs {get;set;}
        public DbSet<Gender> Genders {get;set;}

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {

        } 
       
     }
 }