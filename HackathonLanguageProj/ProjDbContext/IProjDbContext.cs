using HackathonLanguageProj.Entities;
using Microsoft.EntityFrameworkCore;

namespace HackathonLanguageProj.ProjDbContext;

public interface IProjDbContext
{
    DbSet<CountryList> CountryLists { get; set; }
}