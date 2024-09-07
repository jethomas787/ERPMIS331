using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERPMIS331.Models
{
    public partial class ErpUser
    {
        public short UserId { get; set; }
        public string UserName { get; set; }
        public byte[] Password { get; set; }
        public short RoleId { get; set; }
        public short DeptId { get; set; }
        public DateTime DateHired { get; set; }

        public virtual ErpDept Dept { get; set; }
        public virtual ErpRole Role { get; set; }
    }
}
