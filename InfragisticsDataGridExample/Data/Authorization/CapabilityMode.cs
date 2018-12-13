namespace InfragisticsDataGridExample.Data.Authorization
{
    // Differentiates visibility and edit-ability modes
    // NOTE: This class shows the elegance and ease-of-use of the enumeration class pattern
    // as opposed to using enums
    public class CapabilityMode
    {
        public static CapabilityMode Visible { get; } = new CapabilityMode(0, "Visible");
        public static CapabilityMode Hidden { get; } = new CapabilityMode(1, "Hidden");
        public static CapabilityMode Edit { get; } = new CapabilityMode(2, "Edit");

        public string Name { get; }
        public int Value { get; }

        private CapabilityMode(int value, string name)
        {
            Name = name;
            Value = value;
        }
    }
}