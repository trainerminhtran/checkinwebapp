using System;
using System.Collections.Generic;

namespace CheckInWebApp.Models
{
    public partial class ProvinceInfor
    {
        public ProvinceInfor()
        {
            DistrictInfor = new HashSet<DistrictInfor>();
            VenueInfor = new HashSet<VenueInfor>();
        }

        public int Id { get; set; }
        public string NameVn { get; set; }
        public string NameEn { get; set; }
        public int RegionId { get; set; }
        public int? CityRuralId { get; set; }

        public virtual CityRuralInfor CityRural { get; set; }
        public virtual RegionInfor Region { get; set; }
        public virtual ICollection<DistrictInfor> DistrictInfor { get; set; }
        public virtual ICollection<VenueInfor> VenueInfor { get; set; }
    }
}
