using System;
using System.Collections.Generic;

namespace CheckInWebApp.Models
{
    public partial class ContentModelRecord
    {
        public int Id { get; set; }
        public int? ContentId { get; set; }
        public int? ModelId { get; set; }

        public virtual ContentInfor Content { get; set; }
        public virtual ModelInfor Model { get; set; }
    }
}
