/*
 * Karna Johnson
 * CSC 237-040
 * Project 3
 * Description: Making a panel to learn a new way to use gui
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace EquipmentInventory
{
    public class CheckOutPanel : Panel
    {
        public TextBox txtDateCheckOut;
        public Label lblDateCheckOut;
        public TextBox txtTagNum;
        public Label lblTagNum;
        public RichTextBox txtItemInfo;
        public Label lblItemInfo;
        public Label lblSoftItem;
        public Label lblEquipItem;
        public Label lblEquip;
        public Label lblSoft;
        public Label lblCheckItemInfo;
        public bool isEmpty;
        public CheckOutItem emp;
        public CheckOutItemCollection items;
    
        public CheckOutPanel()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(RePaint);
            emp = new CheckOutItem();
            items = new CheckOutItemCollection();

        }
        public void RePaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Graphics gf = e.Graphics;
            g.DrawLine(new Pen(Color.Black), new Point(0, 0), new Point(315, 0));
            gf.DrawLine(new Pen(Color.Black), new Point(0, 175), new Point(315, 175));
        }
        private void InitializeComponent()
        {
            this.txtDateCheckOut = new System.Windows.Forms.TextBox();
            this.lblDateCheckOut = new System.Windows.Forms.Label();
            this.txtTagNum = new System.Windows.Forms.TextBox();
            this.lblTagNum = new System.Windows.Forms.Label();
            this.txtItemInfo = new System.Windows.Forms.RichTextBox();
            this.lblItemInfo = new System.Windows.Forms.Label();
            this.lblCheckItemInfo = new System.Windows.Forms.Label();
            this.lblSoftItem = new System.Windows.Forms.Label();
            this.lblEquipItem = new System.Windows.Forms.Label();
            this.lblEquip = new System.Windows.Forms.Label();
            this.lblSoft = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDateCheckOut
            // 
            this.txtDateCheckOut.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateCheckOut.Location = new System.Drawing.Point(6, 150);
            this.txtDateCheckOut.Name = "txtDateCheckOut";
            this.txtDateCheckOut.Size = new System.Drawing.Size(284, 22);
            this.txtDateCheckOut.TabIndex = 34;
            this.txtDateCheckOut.Enter += new System.EventHandler(this.txtDateCheckOut_Enter);
            // 
            // lblDateCheckOut
            // 
            this.lblDateCheckOut.AutoSize = true;
            this.lblDateCheckOut.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateCheckOut.Location = new System.Drawing.Point(6, 133);
            this.lblDateCheckOut.Name = "lblDateCheckOut";
            this.lblDateCheckOut.Size = new System.Drawing.Size(108, 14);
            this.lblDateCheckOut.TabIndex = 37;
            this.lblDateCheckOut.Text = "Date of Check Out:";
            // 
            // txtTagNum
            // 
            this.txtTagNum.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTagNum.Location = new System.Drawing.Point(6, 111);
            this.txtTagNum.Name = "txtTagNum";
            this.txtTagNum.Size = new System.Drawing.Size(284, 22);
            this.txtTagNum.TabIndex = 33;
            // 
            // lblTagNum
            // 
            this.lblTagNum.AutoSize = true;
            this.lblTagNum.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTagNum.Location = new System.Drawing.Point(6, 96);
            this.lblTagNum.Name = "lblTagNum";
            this.lblTagNum.Size = new System.Drawing.Size(76, 14);
            this.lblTagNum.TabIndex = 38;
            this.lblTagNum.Text = "Tag Number:";
            // 
            // txtItemInfo
            // 
            this.txtItemInfo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemInfo.Location = new System.Drawing.Point(6, 50);
            this.txtItemInfo.Name = "txtItemInfo";
            this.txtItemInfo.Size = new System.Drawing.Size(286, 43);
            this.txtItemInfo.TabIndex = 32;
            this.txtItemInfo.Text = "";
            // 
            // lblItemInfo
            // 
            this.lblItemInfo.AutoSize = true;
            this.lblItemInfo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemInfo.Location = new System.Drawing.Point(48, 235);
            this.lblItemInfo.Name = "lblItemInfo";
            this.lblItemInfo.Size = new System.Drawing.Size(117, 16);
            this.lblItemInfo.TabIndex = 16;
            this.lblItemInfo.Text = "Item Information:";
            // 
            // lblCheckItemInfo
            // 
            this.lblCheckItemInfo.AutoSize = true;
            this.lblCheckItemInfo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckItemInfo.Location = new System.Drawing.Point(14, 200);
            this.lblCheckItemInfo.Name = "lblCheckItemInfo";
            this.lblCheckItemInfo.Size = new System.Drawing.Size(328, 29);
            this.lblCheckItemInfo.TabIndex = 17;
            this.lblCheckItemInfo.Text = "Check Out Item Information";
            // 
            // lblSoftItem
            // 
            this.lblSoftItem.AutoSize = true;
            this.lblSoftItem.BackColor = System.Drawing.Color.Transparent;
            this.lblSoftItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoftItem.Location = new System.Drawing.Point(0, 30);
            this.lblSoftItem.Name = "lblSoftItem";
            this.lblSoftItem.Size = new System.Drawing.Size(178, 16);
            this.lblSoftItem.TabIndex = 42;
            this.lblSoftItem.Text = "Software Item Information:";
            this.lblSoftItem.Visible = false;
            // 
            // lblEquipItem
            // 
            this.lblEquipItem.AutoSize = true;
            this.lblEquipItem.BackColor = System.Drawing.Color.Transparent;
            this.lblEquipItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEquipItem.Location = new System.Drawing.Point(0, 30);
            this.lblEquipItem.Name = "lblEquipItem";
            this.lblEquipItem.Size = new System.Drawing.Size(189, 16);
            this.lblEquipItem.TabIndex = 39;
            this.lblEquipItem.Text = "Equipment Item Information:";
            this.lblEquipItem.Visible = false;
            // 
            // lblEquip
            // 
            this.lblEquip.AutoSize = true;
            this.lblEquip.BackColor = System.Drawing.Color.Transparent;
            this.lblEquip.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquip.Location = new System.Drawing.Point(0, 2);
            this.lblEquip.Name = "lblEquip";
            this.lblEquip.Size = new System.Drawing.Size(264, 29);
            this.lblEquip.TabIndex = 40;
            this.lblEquip.Text = "Equipment Check Out";
            this.lblEquip.Visible = false;
            // 
            // lblSoft
            // 
            this.lblSoft.AutoSize = true;
            this.lblSoft.BackColor = System.Drawing.Color.Transparent;
            this.lblSoft.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoft.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSoft.Location = new System.Drawing.Point(0, 0);
            this.lblSoft.Name = "lblSoft";
            this.lblSoft.Size = new System.Drawing.Size(240, 29);
            this.lblSoft.TabIndex = 41;
            this.lblSoft.Text = "Software Check Out";
            this.lblSoft.Visible = false;
            // 
            // CheckOutPanel
            // 
            this.Controls.Add(this.lblSoftItem);
            this.Controls.Add(this.lblSoft);
            this.Controls.Add(this.lblEquip);
            this.Controls.Add(this.txtDateCheckOut);
            this.Controls.Add(this.lblDateCheckOut);
            this.Controls.Add(this.txtTagNum);
            this.Controls.Add(this.lblTagNum);
            this.Controls.Add(this.txtItemInfo);
            this.Controls.Add(this.lblEquipItem);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        


        private void txtDateCheckOut_Enter(object sender, EventArgs e)
        {
            //getting the date
            try
            {
                DateTime.Parse(txtDateCheckOut.Text);
            }
            catch // or you can change it
            {
                txtDateCheckOut.Text = DateTime.Today.ToShortDateString();
            }
        }
    }

    
    
}
