using System;
using System.Collections.Generic;

namespace CheckInWebApp.Models
{
    public partial class TestQuestionRecord
    {
        public int Id { get; set; }
        public int TestId { get; set; }
        public int QuestionId { get; set; }
        public bool? Status { get; set; }

        public virtual QuestionInfor Question { get; set; }
        public virtual TestInfor Test { get; set; }
    }
}
