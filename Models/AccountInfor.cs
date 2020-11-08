using System;
using System.Collections.Generic;

namespace CheckInWebApp.Models
{
    public partial class AccountInfor
    {
        public AccountInfor()
        {
            StoreInfor = new HashSet<StoreInfor>();
        }

        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Shortname { get; set; }
        public int ChannelId { get; set; }
        public bool? Status { get; set; }

        public virtual ChannelInfor Channel { get; set; }
        public virtual ICollection<StoreInfor> StoreInfor { get; set; }
    }
}
