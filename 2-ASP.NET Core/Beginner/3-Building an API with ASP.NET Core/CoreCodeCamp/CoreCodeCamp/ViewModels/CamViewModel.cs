using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCodeCamp.ViewModels
{
    public class CamViewModel
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public string Moniker { get; set; }
        public string VenueName { get; set; }
        public DateTime EventDate { get; set; } = DateTime.MinValue;
        public string Address1 { get; set; }
        public string CityTown { get; set; }
        [Range(1,100)]
        public int Length { get; set; } = 1;
        public string StateProvince { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        public ICollection<TalkViewModel> Talks { get; set; }

    }
}
