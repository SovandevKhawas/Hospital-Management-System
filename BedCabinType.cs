using System;
using System.Collections.Generic;

namespace MainProject
{
    public partial class BedCabinType
    {
        public BedCabinType()
        {
            BedMasters = new HashSet<BedMaster>();
            CabinMasters = new HashSet<CabinMaster>();
            OtMasters = new HashSet<OtMaster>();
        }

        public int IdNo { get; set; }
        public string TypeName { get; set; } = null!;
        public int AcCode { get; set; }
        public int Charge { get; set; }

        public virtual PhAccledger AcCodeNavigation { get; set; } = null!;
        public virtual ICollection<BedMaster> BedMasters { get; set; }
        public virtual ICollection<CabinMaster> CabinMasters { get; set; }
        public virtual ICollection<OtMaster> OtMasters { get; set; }
    }
}
