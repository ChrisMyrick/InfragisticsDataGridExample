using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using InfragisticsDataGridExample.Data;
using InfragisticsDataGridExample.Library;

namespace InfragisticsDataGridExample.Presentation
{
    public partial class Dialog : Form
    {
        private Claim _claim;
    
        public Dialog()
        {
            InitializeComponent();
        }

        public GridModel Model { get; set; }

        public void Initialize(GridModel model)
        {
            Model = model;

            TxtAccountName.Text = model.AccountName;
            TxtAccountNumber.Text = model.AccountNo;
            TxtGroupName.Text = model.GroupName;
            TxtGroupNumber.Text = model.GroupNo;
            TxtTotalArBalance.Text = model.TotalARBalance.ToString();
            TxtRefundAmount.Text = model.RefundAmt.ToString();
            TxtPayee.Text = model.Payee;
            TxtVendorNumber.Text = model.VendorNo;

            CboAuth.DataSource = new List<string>
            {
                Constants.GroupEdit,
                Constants.AccountEdit,
                Constants.AccountViewGroupEdit,
                Constants.AccountEditGroupView 
            };

            CboAuth.SelectedItem = null;
            CboAuth.SelectedValueChanged += CboAuthSelectedValueChanged;
        }

        private static IEnumerable<Control> GetPermissibleControls(params Control[] controls)
        {
            return controls.ToList();
        }

        private static void SetEnabledProperty(Control control, Capability capability)
        {
            control.Enabled = capability?.Mode == CapabilityMode.Edit;
        }

        private static void SetVisibleProperty(Control control, Capability capability)
        {
            if(control.Enabled)
            {
                control.Visible = true;
            }
            else
            {
                control.Visible = capability?.Mode == CapabilityMode.Visible;
            }
        }

        private void OnBtnCancelClick(object sender, System.EventArgs e)
        {
            Close();
        }

        private void OnBtnOkClick(object sender, System.EventArgs e)
        {
            Close();
        }

        private void ConfigureViewFromClaim()
        {
            //Another option here would be to pull fields inheriting from IPermissibleControl using reflection
            var controls = GetPermissibleControls(TxtGroupName, TxtGroupNumber, TxtAccountName, TxtAccountNumber);

            ConfigureFields(controls);
        }

        private void ConfigureFields(IEnumerable<Control> controls)
        {
            var capabilities = _claim.Capabilities.Where(x => x.Type == CapabilityType.Control).ToList();

            foreach (var control in controls)
            {
                var capability = capabilities.FirstOrDefault(x => x.Name == ((IPermissibleControl)control).CapabilityName);

                SetEnabledProperty(control, capability);
                SetVisibleProperty(control, capability);
            }
        }

        private void CboAuthSelectedValueChanged(object sender, System.EventArgs e)
        {
            _claim = UserAuthBuilder.GetClaim(CboAuth.SelectedValue.ToString());

            ConfigureViewFromClaim();
        }
    }
}
