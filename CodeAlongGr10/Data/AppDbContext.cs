using MCV.Models;
using Microsoft.EntityFrameworkCore;

namespace MCV.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext()
        {

        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options)
        {

        } 

        public DbSet<PersonData> PeopleData { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);

            modelbuilder.Entity<PersonData>().HasData(new PersonData { Id= Guid.NewGuid().ToString(), Name="Andreas Lyckholm", City="Göteborg", PhoneNumber="0768382888"});
            modelbuilder.Entity<PersonData>().HasData(new PersonData { Id = Guid.NewGuid().ToString(), Name = "Christoffer Lyckholm", City = "Göteborg", PhoneNumber = "0761717777" });
            modelbuilder.Entity<PersonData>().HasData(new PersonData { Id = Guid.NewGuid().ToString(), Name = "Sten Sture", City = "Stockholm", PhoneNumber = "0808807652" });            
            modelbuilder.Entity<PersonData>().HasData(new PersonData { Id = Guid.NewGuid().ToString(), Name = "Sven Svensson", City = "Stockholm", PhoneNumber = "085676832" });

        }      
    }
}
