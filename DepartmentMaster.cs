using System;
using System.Collections.Generic;

namespace MainProject
{
    public partial class DepartmentMaster
    {
        public DepartmentMaster()
        {
            IndoorCheckupParameters = new HashSet<IndoorCheckupParameter>();
            OpdIpdFeesMasters = new HashSet<OpdIpdFeesMaster>();
        }

        public int IdNo { get; set; }
        public string DeptNo { get; set; } = null!;
        public string DeptName { get; set; } = null!;
        public string? Category { get; set; }

        public virtual ICollection<IndoorCheckupParameter> IndoorCheckupParameters { get; set; }
        public virtual ICollection<OpdIpdFeesMaster> OpdIpdFeesMasters { get; set; }
    }
}
