using System;
using System.Collections.Generic;

namespace CheckInWebApp.Models
{
    public partial class PositionInfor
    {
        public PositionInfor()
        {
            UserInfor = new HashSet<UserInfor>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<UserInfor> UserInfor { get; set; }
    }
}
