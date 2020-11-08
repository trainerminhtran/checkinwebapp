using System;
using System.Collections.Generic;

namespace CheckInWebApp.Models
{
    public partial class ChannelInfor
    {
        public ChannelInfor()
        {
            AccountInfor = new HashSet<AccountInfor>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AccountInfor> AccountInfor { get; set; }
    }
}
