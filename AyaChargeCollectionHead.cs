using System;
using System.Collections.Generic;

namespace MainProject
{
    public partial class AyaChargeCollectionHead
    {
        public AyaChargeCollectionHead()
        {
            AyaChargeCollectionDetails = new HashSet<AyaChargeCollectionDetail>();
        }

        public int IdNo { get; set; }
        public string? RegNo { get; set; }
        public int CbCode { get; set; }
        public int? TotalAmount { get; set; }

        public virtual PhAccledger CbCodeNavigation { get; set; } = null!;
        public virtual ICollection<AyaChargeCollectionDetail> AyaChargeCollectionDetails { get; set; }
    }
}
