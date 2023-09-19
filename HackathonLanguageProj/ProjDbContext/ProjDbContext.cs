using HackathonLanguageProj.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace HackathonLanguageProj.ProjDbContext
{
    public class ProjDbContext : IdentityDbContext, IProjDbContext
    {

        public ProjDbContext(DbContextOptions<ProjDbContext> DbContextOptions) : base(DbContextOptions)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<CountryList> CountryLists { get; set; }



    }
}
