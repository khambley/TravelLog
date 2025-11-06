using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelLog.Shared
{
    public class TravelEntryDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? LocationName { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public DateTime Date { get; set; }
        public string? Notes { get; set; }
        public int Rating { get; set; }
    }
}