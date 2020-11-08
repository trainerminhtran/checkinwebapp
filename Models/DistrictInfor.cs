using System;
using System.Collections.Generic;

namespace CheckInWebApp.Models
{
    public partial class DistrictInfor
    {
        public DistrictInfor()
        {
            StoreInfor = new HashSet<StoreInfor>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int ProvinceId { get; set; }

        public virtual ProvinceInfor Province { get; set; }
        public virtual ICollection<StoreInfor> StoreInfor { get; set; }
    }
}
