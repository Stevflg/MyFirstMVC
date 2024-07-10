using MyFirstMVC.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFirstMVC.Models.Context.Entities
{
    public class Club
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string  Image { get; set; }

        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public ClubCategory ClubCategory { get; set; }

        [ForeignKey("AppUsers")]
        public string? AppUserId { get; set; }
        public AppUsers AppUsers { get; set; }


    }
}
