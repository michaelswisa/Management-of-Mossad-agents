﻿using System.ComponentModel.DataAnnotations;

namespace ManagementOfMossadAgentsAPI.Models
{
    public class Target
    {
        [Key]
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public Location? Location { get; set; }
        public string? Status { get; set; }
    }
}
