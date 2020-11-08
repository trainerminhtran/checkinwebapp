using System;
using System.Collections.Generic;

namespace CheckInWebApp.Models
{
    public partial class CatInfor
    {
        public CatInfor()
        {
            ModelInfor = new HashSet<ModelInfor>();
            QuestionInfor = new HashSet<QuestionInfor>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Status { get; set; }

        public virtual ICollection<ModelInfor> ModelInfor { get; set; }
        public virtual ICollection<QuestionInfor> QuestionInfor { get; set; }
    }
}
