using System.Windows.Forms;

namespace InfragisticsDataGridExample.Presentation
{
    public class PermissibleTextBox : TextBox, IPermissibleControl
    {
        public string CapabilityName { get; set; }
    }
}
