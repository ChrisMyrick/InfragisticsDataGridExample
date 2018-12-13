namespace InfragisticsDataGridExample.Data.Authorization
{
    // Differentiates view and control types
    // NOTE: This class shows the elegance and ease-of-use of the enumeration class pattern
    // as opposed to using enums
    public class CapabilityType
    {
        public static CapabilityType View { get; } = new CapabilityType(0, "View");
        public static CapabilityType Control { get; } = new CapabilityType(1, "Control");

        public string Name { get; }
        public int Value { get; }

        private CapabilityType(int value, string name)
        {
            Name = name;
            Value = value;
        }
    }
}