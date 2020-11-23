using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        //{
        //    optionBuilder.UseMySQL("server=127.0.0.1; port=3306; user=root; password=3031_elemeNtaL_3031; database=OvoJeTest;");
        //}

        public DbSet<PTT> PTT { get; set; }
        public DbSet<Drzava> Drzava { get; set; }
        public DbSet<Organizacija> Organizacija { get; set; }
        public DbSet<OrganizacionaJedinica> OrganizacionaJedinica { get; set; }
        public DbSet<Uloge> Uloge { get; set; }
        public DbSet<Korisnici> Korisnici { get; set; }
        public DbSet<Korisnici_OrganizacionaJedinica> Korisnici_OrganizacionaJedinica { get; set; }
        public DbSet<ProjekatPlan> ProjekatPlan { get; set; }
        public DbSet<ProjekatAktivnostPlan> ProjekatAktivnostPlan { get; set; }
        public DbSet<ProjekatAktivnostRealizacija> ProjekatAktivnostRealizacija { get; set; }
        public DbSet<Resursi> Resursi { get; set; }
        public DbSet<Status> Status { get; set; }
    }
}