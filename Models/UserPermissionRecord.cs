using System;
using System.Collections.Generic;

namespace CheckInWebApp.Models
{
    public partial class UserPermissionRecord
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PermissionId { get; set; }
        public DateTime Datetime { get; set; }

        public virtual PermissionInfor Permission { get; set; }
        public virtual UserInfor User { get; set; }
    }
}
