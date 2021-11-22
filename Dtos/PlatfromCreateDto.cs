﻿using System.ComponentModel.DataAnnotations;

namespace platformservice.Dtos
{
    public class PlatfromCreateDto
    { 
        [Required]
        public string Name { get; set; }

        [Required]
        public string Publisher { get; set; }

        [Required]
        public string Cost { get; set; }
    }
}
