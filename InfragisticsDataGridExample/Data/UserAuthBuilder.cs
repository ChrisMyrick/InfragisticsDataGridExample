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
                    new DialogCapability(CapabilityMode.Visible)
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
                    new DialogCapability(CapabilityMode.Hidden)
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
                    new GroupCapability(CapabilityMode.Edit)
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
                    new AccountCapability(CapabilityMode.Edit)
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
                    new AccountCapability(CapabilityMode.Visible),
                    new GroupCapability(CapabilityMode.Edit)
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
                    new AccountCapability(CapabilityMode.Edit),
                    new GroupCapability(CapabilityMode.Visible)
                }
            };
        }
    }
}
