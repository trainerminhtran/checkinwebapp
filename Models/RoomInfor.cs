using System;
using System.Collections.Generic;

namespace CheckInWebApp.Models
{
    public partial class RoomInfor
    {
        public RoomInfor()
        {
            CheckinInfor = new HashSet<CheckinInfor>();
        }

        public int Id { get; set; }
        public int CourseId { get; set; }
        public int TrainerId { get; set; }
        public int PlatformId { get; set; }
        public int? VenueId { get; set; }
        public string Name { get; set; }
        public string RoomUrl { get; set; }
        public byte[] QrcodeImage { get; set; }
        public decimal? RoomFee { get; set; }
        public decimal? TeabreakFee { get; set; }
        public bool? Status { get; set; }

        public virtual CourseInfor Course { get; set; }
        public virtual PlatformInfor Platform { get; set; }
        public virtual VenueInfor Venue { get; set; }
        public virtual ICollection<CheckinInfor> CheckinInfor { get; set; }
    }
}
