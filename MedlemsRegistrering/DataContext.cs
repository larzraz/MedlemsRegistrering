
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedlemsRegistrering
{
    public class DataContext :DbContext
    {
        public DbSet<Members> Members { get; set; }
        //public DataContext(DbContextOptions<DataContext> options)
        //    : base(options)
        //{
        //    //Database.EnsureDeleted();
        //    Database.EnsureCreated();
        //    if (Members.Count() == 0)
        //    {
        //        Members.Add(new Members { Name = "Jakob", Age = 22, Gender = "Male" });
        //        Members.Add(new Members { Name = "Jakob", Age = 22, Gender = "Female" });
        //        SaveChanges();
        //    }
        //}

        public DataContext() : base(@"Server=(localdb)\mssqllocaldb;Database=MedlemmerOFC;Trusted_Connection=True;") { }
      

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MedlemmerOFC;Trusted_Connection=True;");
        //}
    }
}
