using System;
using System.Collections.Generic;
using InfragisticsDataGridExample.Library;

namespace InfragisticsDataGridExample.Data.Authorization
{
    // Builds authorization scenarios based on user input
    public class UserAuthorizationFactory
    {
        private static Dictionary<string, Func<Claim>> _scenarioMappings;
        private static readonly string _userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

        static UserAuthorizationFactory()
        {
            BuildScenarioMappings();
        }

        // Configures a dictionary mapping between the user input string and the 
        // scenario building methods
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

        // Uses dictionary to pass through to previously mapped method
        public static Claim GetClaim(string scenario)
        {
            return _scenarioMappings[scenario]();
        }

        private static Claim BuildCanViewDialogScenario()
        {
            return new Claim
            {
                UserName = _userName,
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
                UserName = _userName,
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
                UserName = _userName,
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
                UserName = _userName,
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
                UserName = _userName,
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
                UserName = _userName,
                Capabilities = new List<Capability>
                {
                    new AccountCapability(CapabilityMode.Edit),
                    new GroupCapability(CapabilityMode.Visible)
                }
            };
        }
    }
}
