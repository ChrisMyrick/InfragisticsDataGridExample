namespace InfragisticsDataGridExample.Data.Authorization
{
    // This class tracks and maps types to modes
    public class Capability
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public CapabilityMode Mode { get; set; }
        public CapabilityType Type { get; set; }
    }
}