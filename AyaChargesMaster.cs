using System;
using System.Collections.Generic;

namespace MainProject
{
    public partial class AyaChargesMaster
    {
        public AyaChargesMaster()
        {
            AyaChargeCollectionDetails = new HashSet<AyaChargeCollectionDetail>();
        }

        public int IdNo { get; set; }
        public string AyaTypeName { get; set; } = null!;
        public int ShiftCharge { get; set; }
        public int AcCode { get; set; }

        public virtual PhAccledger AcCodeNavigation { get; set; } = null!;
        public virtual ICollection<AyaChargeCollectionDetail> AyaChargeCollectionDetails { get; set; }
    }
}
