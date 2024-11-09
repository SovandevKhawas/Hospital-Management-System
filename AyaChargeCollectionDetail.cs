using System;
using System.Collections.Generic;

namespace MainProject
{
    public partial class AyaChargeCollectionDetail
    {
        public int IdNo { get; set; }
        public int? HeadId { get; set; }
        public int AyaTypeId { get; set; }
        public int? DayShiftCount { get; set; }
        public int? NightShiftCount { get; set; }
        public decimal? Amount { get; set; }
        public int AcCode { get; set; }

        public virtual PhAccledger AcCodeNavigation { get; set; } = null!;
        public virtual AyaChargesMaster AyaType { get; set; } = null!;
        public virtual AyaChargeCollectionHead? Head { get; set; }
    }
}
