using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using InfragisticsDataGridExample.Data;
using InfragisticsDataGridExample.Library;
using InfragisticsDataGridExample.Service;

namespace InfragisticsDataGridExample.Presentation
{
    public partial class View : Form
    {
        private Claim _claim;

        public View()
        {
            InitializeComponent();

            ConfigureGrid();
            ConfigureComboBox();

            _claim = UserAuthBuilder.GetClaim(Constants.CanViewDialog);
        }

        private static Func<Dto, GridModel> ProjectGridModel()
        {
            return x => new GridModel
            {
                AccountName = x.AccountName,
                AccountNo = x.AccountNo,
                GroupNo = x.GroupNo,
                GroupName = x.GroupName,
                GroupSortName = x.GroupSortName,
                AccountSortName = x.AccountSortName,
                TotalARBalance = x.TotalARBalance,
                RefundAmt = x.RefundAmt,
                Payee = x.Payee,
                PayeeAddress1 = x.PayeeAddress1,
                PayeeAddress2 = x.PayeeAddress2,
                PayeeAddress3 = x.PayeeAddress3,
                PayeeCity = x.PayeeCity,
                PayeeStateCode = x.PayeeStateCode,
                SubDtos = x.SubDtos
            };
        }

        private void ConfigureComboBox()
        {
            CboAuth.DataSource = new List<string> { Constants.CanViewDialog, Constants.CannotViewDialog };

            CboAuth.SelectedItem = null;
            CboAuth.SelectedValueChanged += CboAuthSelectedValueChanged;
        }

        private void ConfigureGrid()
        {
            var service = new DataService();

            var model = service.GetData()
                                .Select(ProjectGridModel())
                                .ToList();

            UltraGrid1.DataSource = model;
            UltraGrid1.DataBind();
        }

        private void OnUltraGrid1DoubleClickRow(object sender, Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs e)
        {
            var model = e.Row.ListObject as GridModel;

            DisplayDialog(model);
        }

        private void CboAuthSelectedValueChanged(object sender, EventArgs e)
        {
            _claim = UserAuthBuilder.GetClaim(CboAuth.SelectedValue.ToString());
        }

        private void DisplayDialog(GridModel model)
        {
            var userHasPermission = _claim.Capabilities.FirstOrDefault(x => x.Type.IsViewBased && x.Name == "Dialog")?.CanView ?? false;

            if(userHasPermission)
            {
                var dialog = new Dialog
                {
                    StartPosition = FormStartPosition.CenterParent
                };

                dialog.Initialize(model);

                dialog.ShowDialog();
            }
            else
            {
                MessageBox.Show("Insufficient permission", "Permission message");
            }
        }
    }
}
