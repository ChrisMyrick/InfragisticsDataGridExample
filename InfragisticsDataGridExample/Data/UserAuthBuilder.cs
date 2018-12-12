using System;
using System.Collections.Generic;
using InfragisticsDataGridExample.Library;

namespace InfragisticsDataGridExample.Data
{
    public class UserAuthBuilder
    {
        private static Dictionary<string, Func<Claim>> _scenarioMappings;

        static UserAuthBuilder()
        {
            BuildScenarioMappings();
        }

        public static void BuildScenarioMappings()
        {
            _scenarioMappings = new Dictionary<string, Func<Claim>>
            {
                { Constants.GroupEdit, BuildGroupEditScenario},
                { Constants.AccountEdit, BuildAccountEditScenario },
                { Constants.AccountEditGroupView, BuildAccountEditGroupViewScenario },
                { Constants.AccountViewGroupEdit, BuildAccountViewGroupEditScenario },
                { Constants.CanViewDialog, BuildCanViewDialogScenario },
                { Constants.CannotViewDialog, BuildCannotViewDialogScenario }
            };
        }

        public static Claim GetClaim(string scenario)
        {
            return _scenarioMappings[scenario]();
        }

        private static Claim BuildCanViewDialogScenario()
        {
            return new Claim
            {
                UserName = System.Security.Principal.WindowsIdentity.GetCurrent().Name,
                Capabilities = new List<Capability>
                {
                    new Capability
                    {
                        Type = new CapabilityType{ IsViewBased = true },
                        Name = "Dialog",
                        CanEdit = true,
                        CanView = true
                    }
                }
            };
        }

        private static Claim BuildCannotViewDialogScenario()
        {
            return new Claim
            {
                UserName = System.Security.Principal.WindowsIdentity.GetCurrent().Name,
                Capabilities = new List<Capability>
                {
                    new Capability
                    {
                        Type = new CapabilityType{ IsViewBased = true },
                        Name = "Dialog",
                        CanEdit = false,
                        CanView = false
                    }
                }
            };
        }

        private static Claim BuildGroupEditScenario()
        {
            return new Claim
            {
                UserName = System.Security.Principal.WindowsIdentity.GetCurrent().Name,
                Capabilities = new List<Capability>
                {
                    new Capability
                    {
                        Type = new CapabilityType{ IsControlBased = true },
                        Name = "Group",
                        CanEdit = true,
                        CanView = true
                    }
                }
            };
        }

        private static Claim BuildAccountEditScenario()
        {
            return new Claim
            {
                UserName = System.Security.Principal.WindowsIdentity.GetCurrent().Name,
                Capabilities = new List<Capability>
                {
                    new Capability
                    {
                        Type = new CapabilityType{ IsControlBased = true },
                        Name = "Account",
                        CanEdit = true,
                        CanView = true
                    }
                }
            };
        }

        private static Claim BuildAccountViewGroupEditScenario()
        {
            return new Claim
            {
                UserName = System.Security.Principal.WindowsIdentity.GetCurrent().Name,
                Capabilities = new List<Capability>
                {
                    new Capability
                    {
                        Type = new CapabilityType{ IsControlBased = true },
                        Name = "Account",
                        CanView = true,
                        CanEdit = false
                    },
                    new Capability
                    {
                        Type = new CapabilityType{ IsControlBased = true },
                        Name = "Group",
                        CanView = true,
                        CanEdit = true

                    }
                }
            };
        }

        private static Claim BuildAccountEditGroupViewScenario()
        {
            return new Claim
            {
                UserName = System.Security.Principal.WindowsIdentity.GetCurrent().Name,
                Capabilities = new List<Capability>
                {
                    new Capability
                    {
                        Type = new CapabilityType{ IsControlBased = true },
                        Name = "Account",
                        CanView = true,
                        CanEdit = true,
                    },
                    new Capability
                    {
                        Type = new CapabilityType{ IsControlBased = true },
                        Name = "Group",
                        CanView = true,
                        CanEdit = false
                    }
                }
            };
        }
    }
}
