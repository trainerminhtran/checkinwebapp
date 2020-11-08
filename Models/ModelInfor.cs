using System;
using System.Collections.Generic;

namespace CheckInWebApp.Models
{
    public partial class ModelInfor
    {
        public ModelInfor()
        {
            ContentModelRecord = new HashSet<ContentModelRecord>();
        }

        public int Id { get; set; }
        public int CatId { get; set; }
        public string Modelcode { get; set; }
        public bool? Status { get; set; }

        public virtual CatInfor Cat { get; set; }
        public virtual ICollection<ContentModelRecord> ContentModelRecord { get; set; }
    }
}
