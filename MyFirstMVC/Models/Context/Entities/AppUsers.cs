using Microsoft.AspNetCore.Identity;

namespace MyFirstMVC.Models.Context.Entities
{
    public class AppUsers : IdentityUser
    {
        public int? Race { get; set; }
        public int? Mileage { get; set; }
        public Address? Address { get; set; }
        public ICollection<Club>? Clubs { get; set; }
        public ICollection<Race> Races { get; set; }

    }
}
