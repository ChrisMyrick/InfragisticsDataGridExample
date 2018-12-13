namespace InfragisticsDataGridExample.Data.Authorization
{
    // Dialog-specific capability
    public class DialogCapability : Capability
    {
        public DialogCapability(CapabilityMode mode)
        {
            Name = "Dialog";
            Value = 0;
            Type = CapabilityType.View;
            Mode = mode;
        }
    }
}