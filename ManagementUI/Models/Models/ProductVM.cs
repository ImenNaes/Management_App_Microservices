﻿using System.ComponentModel.DataAnnotations;

namespace ManagementUI.Models.Models
{
    public class ProductVM
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Description { get; set; } 
    }
}
