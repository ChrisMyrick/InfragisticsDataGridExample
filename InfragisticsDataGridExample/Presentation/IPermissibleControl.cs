namespace InfragisticsDataGridExample.Presentation
{
    // This interface is for extending Winforms controls with additional metadata 
    // useful for governing what controls to hide/show
    public interface IPermissibleControl
    {
        string CapabilityName { get; set; }
    }
}
