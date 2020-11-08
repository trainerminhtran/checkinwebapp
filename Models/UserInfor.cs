using System;
using System.Collections.Generic;

namespace CheckInWebApp.Models
{
    public partial class UserInfor
    {
        public UserInfor()
        {
            CheckinInfor = new HashSet<CheckinInfor>();
            LoginInfor = new HashSet<LoginInfor>();
            UserPermissionRecord = new HashSet<UserPermissionRecord>();
        }

        public int Id { get; set; }
        public int StoreId { get; set; }
        public int PositionId { get; set; }
        public string Fullname { get; set; }
        public string Tel { get; set; }
        public string Password { get; set; }
        public bool Status { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual PositionInfor Position { get; set; }
        public virtual StoreInfor Store { get; set; }
        public virtual ICollection<CheckinInfor> CheckinInfor { get; set; }
        public virtual ICollection<LoginInfor> LoginInfor { get; set; }
        public virtual ICollection<UserPermissionRecord> UserPermissionRecord { get; set; }
    }
}
