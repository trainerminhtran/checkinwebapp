using System;
using System.Collections.Generic;

namespace CheckInWebApp.Models
{
    public partial class AnswerInfor
    {
        public AnswerInfor()
        {
            AnswerRecord = new HashSet<AnswerRecord>();
        }

        public int Id { get; set; }
        public long CheckinInforId { get; set; }
        public decimal? Score { get; set; }
        public DateTime? Datetime { get; set; }

        public virtual CheckinInfor CheckinInfor { get; set; }
        public virtual ICollection<AnswerRecord> AnswerRecord { get; set; }
    }
}
