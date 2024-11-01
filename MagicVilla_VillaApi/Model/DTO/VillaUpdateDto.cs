﻿using System.ComponentModel.DataAnnotations;

namespace MagicVilla_VillaApi.Model.DTO
{
    public class VillaUpdateDto
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]

        public string Details {  get; set; }

        [Required]
        public double Rate {  get; set; }

        [Required]
        public int Occupancy {  get; set; }

        [Required]
        public int Sqft {  get; set; }
        [Required]

        public string ImageUrl { get; set; }
        [Required]

        public string Amenity { get; set; }

    }
}