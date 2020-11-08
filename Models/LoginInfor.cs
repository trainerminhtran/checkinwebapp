using System;
using System.Collections.Generic;

namespace CheckInWebApp.Models
{
    public partial class LoginInfor
    {
        public long Id { get; set; }
        public int UserId { get; set; }
        public string Token { get; set; }
        public byte[] Timestamp { get; set; }
        public bool? Status { get; set; }

        public virtual UserInfor User { get; set; }
    }
}
