using System;
using System.Collections.Generic;

namespace CheckInWebApp.Models
{
    public partial class LevelInfor
    {
        public LevelInfor()
        {
            QuestionInfor = new HashSet<QuestionInfor>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<QuestionInfor> QuestionInfor { get; set; }
    }
}
