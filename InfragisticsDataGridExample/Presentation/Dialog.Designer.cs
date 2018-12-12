namespace InfragisticsDataGridExample.Presentation
{
    partial class Dialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnOk = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAccountName = new InfragisticsDataGridExample.Presentation.PermissibleTextBox();
            this.TxtAccountNumber = new InfragisticsDataGridExample.Presentation.PermissibleTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtGroupName = new InfragisticsDataGridExample.Presentation.PermissibleTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtGroupNumber = new InfragisticsDataGridExample.Presentation.PermissibleTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtTotalArBalance = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtRefundAmount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtPayee = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtVendorNumber = new System.Windows.Forms.TextBox();
            this.CboAuth = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(948, 398);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(115, 53);
            this.BtnOk.TabIndex = 0;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.OnBtnOkClick);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(812, 398);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(113, 53);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.OnBtnCancelClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Account Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Account #";
            // 
            // TxtAccountName
            // 
            this.TxtAccountName.CapabilityName = "Account";
            this.TxtAccountName.Location = new System.Drawing.Point(139, 49);
            this.TxtAccountName.Name = "TxtAccountName";
            this.TxtAccountName.Size = new System.Drawing.Size(350, 26);
            this.TxtAccountName.TabIndex = 4;
            // 
            // TxtAccountNumber
            // 
            this.TxtAccountNumber.CapabilityName = "Account";
            this.TxtAccountNumber.Location = new System.Drawing.Point(139, 108);
            this.TxtAccountNumber.Name = "TxtAccountNumber";
            this.TxtAccountNumber.Size = new System.Drawing.Size(350, 26);
            this.TxtAccountNumber.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Group Name";
            // 
            // TxtGroupName
            // 
            this.TxtGroupName.CapabilityName = "Group";
            this.TxtGroupName.Location = new System.Drawing.Point(139, 176);
            this.TxtGroupName.Name = "TxtGroupName";
            this.TxtGroupName.Size = new System.Drawing.Size(350, 26);
            this.TxtGroupName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Group Number";
            // 
            // TxtGroupNumber
            // 
            this.TxtGroupNumber.CapabilityName = "Group";
            this.TxtGroupNumber.Location = new System.Drawing.Point(139, 242);
            this.TxtGroupNumber.Name = "TxtGroupNumber";
            this.TxtGroupNumber.Size = new System.Drawing.Size(350, 26);
            this.TxtGroupNumber.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(521, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Total AR Balance";
            // 
            // TxtTotalArBalance
            // 
            this.TxtTotalArBalance.Location = new System.Drawing.Point(660, 46);
            this.TxtTotalArBalance.Name = "TxtTotalArBalance";
            this.TxtTotalArBalance.Size = new System.Drawing.Size(403, 26);
            this.TxtTotalArBalance.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(532, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Refund Amount";
            // 
            // TxtRefundAmount
            // 
            this.TxtRefundAmount.Location = new System.Drawing.Point(660, 105);
            this.TxtRefundAmount.Name = "TxtRefundAmount";
            this.TxtRefundAmount.Size = new System.Drawing.Size(403, 26);
            this.TxtRefundAmount.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(601, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Payee";
            // 
            // TxtPayee
            // 
            this.TxtPayee.Location = new System.Drawing.Point(660, 179);
            this.TxtPayee.Name = "TxtPayee";
            this.TxtPayee.Size = new System.Drawing.Size(403, 26);
            this.TxtPayee.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(533, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Vendor Number";
            // 
            // TxtVendorNumber
            // 
            this.TxtVendorNumber.Location = new System.Drawing.Point(660, 242);
            this.TxtVendorNumber.Name = "TxtVendorNumber";
            this.TxtVendorNumber.Size = new System.Drawing.Size(403, 26);
            this.TxtVendorNumber.TabIndex = 17;
            // 
            // CboAuth
            // 
            this.CboAuth.FormattingEnabled = true;
            this.CboAuth.Location = new System.Drawing.Point(183, 355);
            this.CboAuth.Name = "CboAuth";
            this.CboAuth.Size = new System.Drawing.Size(263, 28);
            this.CboAuth.TabIndex = 18;
            this.CboAuth.Text = "Select user authorization";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 358);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Control Authorization";
            // 
            // Dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 483);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CboAuth);
            this.Controls.Add(this.TxtVendorNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtPayee);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtRefundAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtTotalArBalance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtGroupNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtGroupName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtAccountNumber);
            this.Controls.Add(this.TxtAccountName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOk);
            this.Name = "Dialog";
            this.Text = "Dialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private PermissibleTextBox TxtAccountName;
        private PermissibleTextBox TxtAccountNumber;
        private System.Windows.Forms.Label label3;
        private PermissibleTextBox TxtGroupName;
        private System.Windows.Forms.Label label4;
        private PermissibleTextBox TxtGroupNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtTotalArBalance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtRefundAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtPayee;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtVendorNumber;
        private System.Windows.Forms.ComboBox CboAuth;
        private System.Windows.Forms.Label label9;
    }
}