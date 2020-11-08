using System;
using System.Collections.Generic;

namespace CheckInWebApp.Models
{
    public partial class PlatformInfor
    {
        public PlatformInfor()
        {
            RoomInfor = new HashSet<RoomInfor>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<RoomInfor> RoomInfor { get; set; }
    }
}
