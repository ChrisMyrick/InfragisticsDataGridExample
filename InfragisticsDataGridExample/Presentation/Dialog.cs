using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using InfragisticsDataGridExample.Data;
using InfragisticsDataGridExample.Data.Authorization;
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

            // Intentionally doing this after setting the datasource
            // because otherwise, it triggers the event
            CboAuth.SelectedItem = null;
            CboAuth.SelectedValueChanged += CboAuthSelectedValueChanged;
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
            var controls = GetPermissibleControls();

            ConfigureFields(controls);
        }

        private IEnumerable<Control> GetPermissibleControls()
        {
            //Another option here would be to pull fields inheriting from IPermissibleControl using reflection
            return new List<Control>
            {
                LblGroupName,
                TxtGroupName,
                LblGroupNumber,
                TxtGroupNumber,
                LblAccountName,
                TxtAccountName,
                LblAccountNumber,
                TxtAccountNumber
            };
        }

        private void ConfigureFields(IEnumerable<Control> controls)
        {
            var capabilities = _claim.Capabilities.Where(x => x.Type == CapabilityType.Control).ToList();

            foreach (var control in controls)
            {
                var controlCapabilityName = ((IPermissibleControl)control).CapabilityName;
                var capability = capabilities.FirstOrDefault(x => x.Name == controlCapabilityName);

                SetEnabledProperty(control, capability);
                SetVisibleProperty(control, capability);
            }
        }

        private void CboAuthSelectedValueChanged(object sender, System.EventArgs e)
        {
            _claim = UserAuthorizationFactory.GetClaim(CboAuth.SelectedValue.ToString());

            ConfigureViewFromClaim();
        }
    }
}
