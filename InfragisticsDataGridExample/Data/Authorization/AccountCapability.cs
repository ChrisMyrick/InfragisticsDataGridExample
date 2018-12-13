namespace InfragisticsDataGridExample.Data.Authorization
{
    // Account-specific capability
    public class AccountCapability : Capability
    {
        public AccountCapability(CapabilityMode mode)
        {
            Name = "Account";
            Value = 2;
            Type = CapabilityType.Control;
            Mode = mode;
        }
    }
}