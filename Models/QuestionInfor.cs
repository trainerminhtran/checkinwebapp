using System;
using System.Collections.Generic;

namespace CheckInWebApp.Models
{
    public partial class QuestionInfor
    {
        public QuestionInfor()
        {
            AnswerRecord = new HashSet<AnswerRecord>();
            TestQuestionRecord = new HashSet<TestQuestionRecord>();
        }

        public int Id { get; set; }
        public int CatId { get; set; }
        public int LevelId { get; set; }
        public string QuestionContent { get; set; }
        public string TrueChoose { get; set; }
        public string Choose1 { get; set; }
        public string Choose2 { get; set; }
        public string Choose3 { get; set; }
        public string Choose4 { get; set; }
        public DateTime? Datetime { get; set; }
        public bool? Status { get; set; }

        public virtual CatInfor Cat { get; set; }
        public virtual LevelInfor Level { get; set; }
        public virtual ICollection<AnswerRecord> AnswerRecord { get; set; }
        public virtual ICollection<TestQuestionRecord> TestQuestionRecord { get; set; }
    }
}
