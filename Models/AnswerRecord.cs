using System;
using System.Collections.Generic;

namespace CheckInWebApp.Models
{
    public partial class AnswerRecord
    {
        public int Id { get; set; }
        public int AnswerId { get; set; }
        public int QuesionId { get; set; }
        public string AnswerOption { get; set; }
        public DateTime? Datetime { get; set; }

        public virtual AnswerInfor Answer { get; set; }
        public virtual QuestionInfor Quesion { get; set; }
    }
}
