﻿using System.ComponentModel.DataAnnotations;

namespace MyFirstMVC.Models.Context.Entities
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Street { get; set; }

        [Required]
        [StringLength(50)]
        public string City { get; set; }

        [Required]
        [StringLength(50)]
        public string State { get; set; }

    }
}
