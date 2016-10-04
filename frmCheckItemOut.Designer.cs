namespace EquipmentInventory
{
    partial class frmCheckItemOut
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
            this.lblEmpInfo = new System.Windows.Forms.Label();
            this.lblEmpFirst = new System.Windows.Forms.Label();
            this.txtEmpFirst = new System.Windows.Forms.TextBox();
            this.lblEmpLast = new System.Windows.Forms.Label();
            this.txtEmpLast = new System.Windows.Forms.TextBox();
            this.lblEmpEmail = new System.Windows.Forms.Label();
            this.txtEmpEmail = new System.Windows.Forms.TextBox();
            this.lblEmpEmailCorrect = new System.Windows.Forms.Label();
            this.radYes = new System.Windows.Forms.RadioButton();
            this.radNo = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblSNum = new System.Windows.Forms.Label();
            this.txtSNum = new System.Windows.Forms.TextBox();
            this.radYesCorrect = new System.Windows.Forms.RadioButton();
            this.grpAction = new System.Windows.Forms.GroupBox();
            this.radHidden = new System.Windows.Forms.RadioButton();
            this.radInvent = new System.Windows.Forms.RadioButton();
            this.radSoft = new System.Windows.Forms.RadioButton();
            this.radEquip = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.chkAccept = new System.Windows.Forms.CheckBox();
            this.panCheck = new EquipmentInventory.CheckOutPanel();
            this.grpAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmpInfo
            // 
            this.lblEmpInfo.AutoSize = true;
            this.lblEmpInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpInfo.Location = new System.Drawing.Point(12, 9);
            this.lblEmpInfo.Name = "lblEmpInfo";
            this.lblEmpInfo.Size = new System.Drawing.Size(319, 33);
            this.lblEmpInfo.TabIndex = 23;
            this.lblEmpInfo.Text = "Employee Information";
            // 
            // lblEmpFirst
            // 
            this.lblEmpFirst.AutoSize = true;
            this.lblEmpFirst.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpFirst.Location = new System.Drawing.Point(36, 81);
            this.lblEmpFirst.Name = "lblEmpFirst";
            this.lblEmpFirst.Size = new System.Drawing.Size(129, 15);
            this.lblEmpFirst.TabIndex = 21;
            this.lblEmpFirst.Text = "Employee First Name:";
            // 
            // txtEmpFirst
            // 
            this.txtEmpFirst.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpFirst.Location = new System.Drawing.Point(169, 77);
            this.txtEmpFirst.Name = "txtEmpFirst";
            this.txtEmpFirst.Size = new System.Drawing.Size(151, 22);
            this.txtEmpFirst.TabIndex = 1;
            this.txtEmpFirst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpFirst_KeyPress);
            // 
            // lblEmpLast
            // 
            this.lblEmpLast.AutoSize = true;
            this.lblEmpLast.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpLast.Location = new System.Drawing.Point(35, 109);
            this.lblEmpLast.Name = "lblEmpLast";
            this.lblEmpLast.Size = new System.Drawing.Size(129, 15);
            this.lblEmpLast.TabIndex = 20;
            this.lblEmpLast.Text = "Employee Last Name:";
            // 
            // txtEmpLast
            // 
            this.txtEmpLast.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpLast.Location = new System.Drawing.Point(171, 105);
            this.txtEmpLast.Name = "txtEmpLast";
            this.txtEmpLast.Size = new System.Drawing.Size(150, 22);
            this.txtEmpLast.TabIndex = 2;
            this.txtEmpLast.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpLast_KeyPress);
            this.txtEmpLast.Leave += new System.EventHandler(this.txtEmpLast_Leave);
            // 
            // lblEmpEmail
            // 
            this.lblEmpEmail.AutoSize = true;
            this.lblEmpEmail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpEmail.Location = new System.Drawing.Point(65, 137);
            this.lblEmpEmail.Name = "lblEmpEmail";
            this.lblEmpEmail.Size = new System.Drawing.Size(99, 15);
            this.lblEmpEmail.TabIndex = 19;
            this.lblEmpEmail.Text = "Employee Email:";
            // 
            // txtEmpEmail
            // 
            this.txtEmpEmail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpEmail.Location = new System.Drawing.Point(171, 133);
            this.txtEmpEmail.Name = "txtEmpEmail";
            this.txtEmpEmail.ReadOnly = true;
            this.txtEmpEmail.Size = new System.Drawing.Size(150, 22);
            this.txtEmpEmail.TabIndex = 3;
            this.txtEmpEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpEmail_KeyPress);
            // 
            // lblEmpEmailCorrect
            // 
            this.lblEmpEmailCorrect.AutoSize = true;
            this.lblEmpEmailCorrect.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpEmailCorrect.Location = new System.Drawing.Point(16, 164);
            this.lblEmpEmailCorrect.Name = "lblEmpEmailCorrect";
            this.lblEmpEmailCorrect.Size = new System.Drawing.Size(205, 15);
            this.lblEmpEmailCorrect.TabIndex = 18;
            this.lblEmpEmailCorrect.Text = "Is Default Employee Email Correct?";
            // 
            // radYes
            // 
            this.radYes.AutoSize = true;
            this.radYes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radYes.Location = new System.Drawing.Point(225, 161);
            this.radYes.Name = "radYes";
            this.radYes.Size = new System.Drawing.Size(47, 20);
            this.radYes.TabIndex = 4;
            this.radYes.TabStop = true;
            this.radYes.Text = "Yes";
            this.radYes.UseVisualStyleBackColor = true;
            this.radYes.CheckedChanged += new System.EventHandler(this.radYes_CheckedChanged);
            // 
            // radNo
            // 
            this.radNo.AutoSize = true;
            this.radNo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNo.Location = new System.Drawing.Point(278, 161);
            this.radNo.Name = "radNo";
            this.radNo.Size = new System.Drawing.Size(43, 20);
            this.radNo.TabIndex = 8;
            this.radNo.TabStop = true;
            this.radNo.Text = "No";
            this.radNo.UseVisualStyleBackColor = true;
            this.radNo.CheckedChanged += new System.EventHandler(this.radNo_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(19, 235);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(137, 37);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(188, 235);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(132, 36);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblSNum
            // 
            this.lblSNum.AutoSize = true;
            this.lblSNum.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSNum.Location = new System.Drawing.Point(81, 53);
            this.lblSNum.Name = "lblSNum";
            this.lblSNum.Size = new System.Drawing.Size(83, 15);
            this.lblSNum.TabIndex = 22;
            this.lblSNum.Text = "Employee S#:";
            // 
            // txtSNum
            // 
            this.txtSNum.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSNum.Location = new System.Drawing.Point(170, 50);
            this.txtSNum.Name = "txtSNum";
            this.txtSNum.Size = new System.Drawing.Size(151, 21);
            this.txtSNum.TabIndex = 0;
            // 
            // radYesCorrect
            // 
            this.radYesCorrect.AutoSize = true;
            this.radYesCorrect.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radYesCorrect.Location = new System.Drawing.Point(227, 161);
            this.radYesCorrect.Name = "radYesCorrect";
            this.radYesCorrect.Size = new System.Drawing.Size(47, 20);
            this.radYesCorrect.TabIndex = 4;
            this.radYesCorrect.TabStop = true;
            this.radYesCorrect.Text = "Yes";
            this.radYesCorrect.UseVisualStyleBackColor = true;
            this.radYesCorrect.Visible = false;
            // 
            // grpAction
            // 
            this.grpAction.Controls.Add(this.radHidden);
            this.grpAction.Controls.Add(this.radInvent);
            this.grpAction.Controls.Add(this.radSoft);
            this.grpAction.Controls.Add(this.radEquip);
            this.grpAction.Location = new System.Drawing.Point(13, 182);
            this.grpAction.Name = "grpAction";
            this.grpAction.Size = new System.Drawing.Size(308, 49);
            this.grpAction.TabIndex = 5;
            this.grpAction.TabStop = false;
            this.grpAction.Text = "Action Menu";
            // 
            // radHidden
            // 
            this.radHidden.AutoSize = true;
            this.radHidden.Checked = true;
            this.radHidden.Location = new System.Drawing.Point(123, 73);
            this.radHidden.Name = "radHidden";
            this.radHidden.Size = new System.Drawing.Size(85, 17);
            this.radHidden.TabIndex = 3;
            this.radHidden.TabStop = true;
            this.radHidden.Text = "radioButton4";
            this.radHidden.UseVisualStyleBackColor = true;
            this.radHidden.Visible = false;
            // 
            // radInvent
            // 
            this.radInvent.AutoSize = true;
            this.radInvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radInvent.Location = new System.Drawing.Point(215, 17);
            this.radInvent.Name = "radInvent";
            this.radInvent.Size = new System.Drawing.Size(89, 20);
            this.radInvent.TabIndex = 2;
            this.radInvent.Text = "Inventory";
            this.radInvent.UseVisualStyleBackColor = true;
            this.radInvent.CheckedChanged += new System.EventHandler(this.radInvent_CheckedChanged);
            // 
            // radSoft
            // 
            this.radSoft.AutoSize = true;
            this.radSoft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSoft.Location = new System.Drawing.Point(122, 17);
            this.radSoft.Name = "radSoft";
            this.radSoft.Size = new System.Drawing.Size(86, 20);
            this.radSoft.TabIndex = 1;
            this.radSoft.Text = "Software";
            this.radSoft.UseVisualStyleBackColor = true;
            this.radSoft.CheckedChanged += new System.EventHandler(this.radSoft_CheckedChanged);
            // 
            // radEquip
            // 
            this.radEquip.AutoSize = true;
            this.radEquip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radEquip.Location = new System.Drawing.Point(6, 17);
            this.radEquip.Name = "radEquip";
            this.radEquip.Size = new System.Drawing.Size(99, 20);
            this.radEquip.TabIndex = 0;
            this.radEquip.Text = "Equipment";
            this.radEquip.UseVisualStyleBackColor = true;
            this.radEquip.CheckedChanged += new System.EventHandler(this.radEquip_CheckedChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(19, 493);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(301, 32);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Submit Request";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // chkAccept
            // 
            this.chkAccept.AutoSize = true;
            this.chkAccept.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAccept.Location = new System.Drawing.Point(38, 461);
            this.chkAccept.Name = "chkAccept";
            this.chkAccept.Size = new System.Drawing.Size(259, 22);
            this.chkAccept.TabIndex = 10;
            this.chkAccept.Text = "Accept Terms of User Agreement";
            this.chkAccept.UseVisualStyleBackColor = true;
            // 
            // panCheck
            // 
            this.panCheck.Location = new System.Drawing.Point(19, 273);
            this.panCheck.Name = "panCheck";
            this.panCheck.Size = new System.Drawing.Size(301, 182);
            this.panCheck.TabIndex = 9;
            // 
            // frmCheckItemOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 537);
            this.Controls.Add(this.chkAccept);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.panCheck);
            this.Controls.Add(this.grpAction);
            this.Controls.Add(this.radYesCorrect);
            this.Controls.Add(this.txtSNum);
            this.Controls.Add(this.lblSNum);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.radNo);
            this.Controls.Add(this.radYes);
            this.Controls.Add(this.lblEmpEmailCorrect);
            this.Controls.Add(this.txtEmpEmail);
            this.Controls.Add(this.lblEmpEmail);
            this.Controls.Add(this.txtEmpLast);
            this.Controls.Add(this.lblEmpLast);
            this.Controls.Add(this.txtEmpFirst);
            this.Controls.Add(this.lblEmpFirst);
            this.Controls.Add(this.lblEmpInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmCheckItemOut";
            this.Text = "Equipment Item Check Out";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCheckItemOut_FormClosing);
            this.grpAction.ResumeLayout(false);
            this.grpAction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpInfo;
        private System.Windows.Forms.Label lblEmpFirst;
        private System.Windows.Forms.TextBox txtEmpFirst;
        private System.Windows.Forms.Label lblEmpLast;
        private System.Windows.Forms.TextBox txtEmpLast;
        private System.Windows.Forms.Label lblEmpEmail;
        private System.Windows.Forms.TextBox txtEmpEmail;
        private System.Windows.Forms.Label lblEmpEmailCorrect;
        private System.Windows.Forms.RadioButton radYes;
        private System.Windows.Forms.RadioButton radNo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblSNum;
        private System.Windows.Forms.TextBox txtSNum;
        private System.Windows.Forms.RadioButton radYesCorrect;
        private System.Windows.Forms.GroupBox grpAction;
        private System.Windows.Forms.RadioButton radHidden;
        private System.Windows.Forms.RadioButton radInvent;
        private System.Windows.Forms.RadioButton radSoft;
        private System.Windows.Forms.RadioButton radEquip;
        private CheckOutPanel panCheck;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.CheckBox chkAccept;
    }
}

