using System;
using System.Collections.Generic;

namespace MainProject
{
    public partial class FeeTypeMaster
    {
        public FeeTypeMaster()
        {
            OpdIpdFeesMasters = new HashSet<OpdIpdFeesMaster>();
        }

        public int IdNo { get; set; }
        public string FeeTypeName { get; set; } = null!;

        public virtual ICollection<OpdIpdFeesMaster> OpdIpdFeesMasters { get; set; }
    }
}
