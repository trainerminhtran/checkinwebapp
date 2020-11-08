using System;
using System.Collections.Generic;

namespace CheckInWebApp.Models
{
    public partial class CityRuralInfor
    {
        public CityRuralInfor()
        {
            ProvinceInfor = new HashSet<ProvinceInfor>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ProvinceInfor> ProvinceInfor { get; set; }
    }
}
