using System.ComponentModel.DataAnnotations;

namespace HackathonLanguageProj.Entities
{
    public class CountryList
    {
        [Key]
        public int Id { get; set; } 
        public int CountryId { get; set; }
        public int Countryname { get; set; }
        public string ZipCode { get; set; }

    }
}