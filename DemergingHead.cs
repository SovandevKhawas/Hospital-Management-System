using System;
using System.Collections.Generic;

namespace MainProject
{
    public partial class DemergingHead
    {
        public DemergingHead()
        {
            DemergingDtls = new HashSet<DemergingDtl>();
        }

        public int IdNo { get; set; }
        public string DocNo { get; set; } = null!;
        public DateTime DocDate { get; set; }
        public string? ReasonsForDemerging { get; set; }

        public virtual ICollection<DemergingDtl> DemergingDtls { get; set; }
    }
}
