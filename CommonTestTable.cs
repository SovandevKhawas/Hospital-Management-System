using System;
using System.Collections.Generic;

namespace MainProject
{
    public partial class CommonTestTable
    {
        public int CommonTestId { get; set; }
        public string? CommonTestType { get; set; }
        public int? TestId { get; set; }

        public virtual LabMaster? Test { get; set; }
    }
}
