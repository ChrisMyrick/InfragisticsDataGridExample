namespace InfragisticsDataGridExample.Data.Authorization
{
    public class GroupCapability : Capability
    {
        // Group-specific capability
        public GroupCapability(CapabilityMode mode)
        {
            Name = "Group";
            Value = 1;
            Type = CapabilityType.Control;
            Mode = mode;
        }
    }
}