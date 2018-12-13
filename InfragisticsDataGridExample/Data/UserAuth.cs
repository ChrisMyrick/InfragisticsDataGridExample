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
        public string Name { get; set; }
        public int Value { get; set; }

        public CapabilityMode Mode { get; set; }
        public CapabilityType Type { get; set; }
    }

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

    public class GroupCapability : Capability
    {
        public GroupCapability(CapabilityMode mode)
        {
            Name = "Group";
            Value = 1;
            Type = CapabilityType.Control;
            Mode = mode;
        }
    }

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

    public class CapabilityMode
    {
        public static CapabilityMode Visible { get; } = new CapabilityMode(0, "ViewOnly");
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
