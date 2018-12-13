namespace InfragisticsDataGridExample.Presentation
{
    public class PermissibleLabel : System.Windows.Forms.Label, IPermissibleControl
    {
        public string CapabilityName { get; set; }
    }
}
