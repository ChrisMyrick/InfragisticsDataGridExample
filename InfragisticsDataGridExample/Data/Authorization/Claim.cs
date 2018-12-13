using System.Collections.Generic;

namespace InfragisticsDataGridExample.Data.Authorization
{
    // This class tracks what a user can and cannot do through capabilities
    public class Claim
    {
        public string UserName { get; set; }

        public List<Capability> Capabilities { get; set; }
    }
}
