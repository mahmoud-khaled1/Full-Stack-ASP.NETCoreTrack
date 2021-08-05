
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CoreCodeCamp
{
      public class Camp
      {
        public int CampId { get; set; }
        public string Name { get; set; }
        public string Moniker { get; set; }
        public Location Location  { get; set; }
        public DateTime EventDate { get; set; } = DateTime.MinValue;
        public int Length { get; set; } = 1;
        public Collection<Talk> Talks { get; set; }
      }
}