using System;
using System.Collections.Generic;

namespace CheckInWebApp.Models
{
    public partial class StoreInfor
    {
        public StoreInfor()
        {
            UserInfor = new HashSet<UserInfor>();
        }

        public int Id { get; set; }
        public int AccountId { get; set; }
        public int DistrictId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Mcscode { get; set; }
        public string DealeCode { get; set; }
        public bool? Status { get; set; }

        public virtual AccountInfor Account { get; set; }
        public virtual DistrictInfor District { get; set; }
        public virtual ICollection<UserInfor> UserInfor { get; set; }
    }
}
