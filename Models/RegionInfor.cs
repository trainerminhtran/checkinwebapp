using System;
using System.Collections.Generic;

namespace CheckInWebApp.Models
{
    public partial class RegionInfor
    {
        public RegionInfor()
        {
            ProvinceInfor = new HashSet<ProvinceInfor>();
        }

        public int Id { get; set; }
        public int AreaId { get; set; }
        public string NameVn { get; set; }
        public string NameEn { get; set; }

        public virtual AreaInfor Area { get; set; }
        public virtual ICollection<ProvinceInfor> ProvinceInfor { get; set; }
    }
}
