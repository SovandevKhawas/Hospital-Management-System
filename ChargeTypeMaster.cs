using System;
using System.Collections.Generic;

namespace MainProject
{
    public partial class ChargeTypeMaster
    {
        public ChargeTypeMaster()
        {
            OpdIpdFeesMasters = new HashSet<OpdIpdFeesMaster>();
        }

        public int IdNo { get; set; }
        public string ChargeTypeName { get; set; } = null!;

        public virtual ICollection<OpdIpdFeesMaster> OpdIpdFeesMasters { get; set; }
    }
}
