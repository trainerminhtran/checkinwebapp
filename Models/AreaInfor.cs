using System;
using System.Collections.Generic;

namespace CheckInWebApp.Models
{
    public partial class AreaInfor
    {
        public AreaInfor()
        {
            RegionInfor = new HashSet<RegionInfor>();
        }

        public int Id { get; set; }
        public string NameVn { get; set; }
        public string NameEn { get; set; }

        public virtual ICollection<RegionInfor> RegionInfor { get; set; }
    }
}
