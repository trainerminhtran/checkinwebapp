using System;
using System.Collections.Generic;

namespace CheckInWebApp.Models
{
    public partial class PermissionInfor
    {
        public PermissionInfor()
        {
            UserPermissionRecord = new HashSet<UserPermissionRecord>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Status { get; set; }

        public virtual ICollection<UserPermissionRecord> UserPermissionRecord { get; set; }
    }
}
