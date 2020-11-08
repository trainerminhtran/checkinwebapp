using System;
using System.Collections.Generic;

namespace CheckInWebApp.Models
{
    public partial class CheckinInfor
    {
        public CheckinInfor()
        {
            AnswerInfor = new HashSet<AnswerInfor>();
            CheckinImageRecord = new HashSet<CheckinImageRecord>();
        }

        public long Id { get; set; }
        public int UserId { get; set; }
        public int RoomId { get; set; }
        public byte[] Signature { get; set; }
        public bool? IsMotivationGift { get; set; }
        public bool? IsMotivationActive { get; set; }
        public bool? IsDoorGift { get; set; }
        public bool? IsRecheckAnswer { get; set; }
        public DateTime? Datetime { get; set; }

        public virtual RoomInfor Room { get; set; }
        public virtual UserInfor User { get; set; }
        public virtual ICollection<AnswerInfor> AnswerInfor { get; set; }
        public virtual ICollection<CheckinImageRecord> CheckinImageRecord { get; set; }
    }
}
