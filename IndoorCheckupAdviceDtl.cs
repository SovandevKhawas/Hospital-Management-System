using System;
using System.Collections.Generic;

namespace MainProject
{
    public partial class IndoorCheckupAdviceDtl
    {
        public IndoorCheckupAdviceDtl()
        {
            IndoorCheckupAdviceInfos = new HashSet<IndoorCheckupAdviceInfo>();
        }

        public int IdNo { get; set; }
        public int IndoorCheckupAdviceHeadIdNo { get; set; }
        public int? BedMasterIdNo { get; set; }
        public int? CabinMasterIdNo { get; set; }
        public int WardSisterMasterIdNo { get; set; }
        public DateTime BedOccupiedFrom { get; set; }
        public DateTime? BedOccupiedTo { get; set; }
        public int RowNum { get; set; }
        public string? JsonString { get; set; }
        public int? NotificationUniqueId { get; set; }

        public virtual BedMaster? BedMasterIdNoNavigation { get; set; }
        public virtual CabinMaster? CabinMasterIdNoNavigation { get; set; }
        public virtual IndoorCheckupAdviceHead IndoorCheckupAdviceHeadIdNoNavigation { get; set; } = null!;
        public virtual WardSisterMaster WardSisterMasterIdNoNavigation { get; set; } = null!;
        public virtual ICollection<IndoorCheckupAdviceInfo> IndoorCheckupAdviceInfos { get; set; }
    }
}
