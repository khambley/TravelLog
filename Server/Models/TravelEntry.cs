using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelLog.Server.Models
{
    public class TravelEntry
    {
        public int Id { get; set; }

        [Required, MaxLength(120)]
        public string Title { get; set; } = string.Empty;

        [MaxLength(200)]
        public string? LocationName { get; set; }

        // Optional coordinates from geolocation/Map click
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; } = DateTime.UtcNow.Date;

        public string? Notes { get; set; }

        [Range(0, 5)]
        public int Rating { get; set; }

        // Tie entries to the signed-in user
        [Required]
        public string OwnerUserId { get; set; } = string.Empty;
    }
}