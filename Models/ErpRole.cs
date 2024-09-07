using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERPMIS331.Models
{
    public partial class ErpRole
    {
        public ErpRole()
        {
            ErpUser = new HashSet<ErpUser>();
        }

        public short RoleId { get; set; }
        public string Role { get; set; }

        public virtual ICollection<ErpUser> ErpUser { get; set; }
    }
}
