using System;
using System.Collections.Generic;

namespace CheckInWebApp.Models
{
    public partial class VenueInfor
    {
        public VenueInfor()
        {
            RoomInfor = new HashSet<RoomInfor>();
        }

        public int Id { get; set; }
        public int ReceptionId { get; set; }
        public int? ProvinceId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public bool? Status { get; set; }

        public virtual ProvinceInfor Province { get; set; }
        public virtual ICollection<RoomInfor> RoomInfor { get; set; }
    }
}
