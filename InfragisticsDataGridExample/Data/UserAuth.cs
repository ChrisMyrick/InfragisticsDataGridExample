using System.Collections.Generic;

namespace InfragisticsDataGridExample.Data
{
    public class Claim
    {
        public string UserName { get; set; }

        public List<Capability> Capabilities { get; set; }
    }

    public class Capability
    {
        public CapabilityType Type { get; set; }

        public string Name { get; set; }

        public bool CanView { get; set; }

        public bool CanEdit { get; set; }
    }

    public class CapabilityType
    {
        public bool IsViewBased { get; set; }

        public bool IsControlBased { get; set; }
    }
}
