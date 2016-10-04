/*
 * Karna Johnson
 * CSC 237-040
 * Project 3 - Equipment Inventory
 * Description: Having the user submit details about their 
 *              item check out and their employee details
 *              with multiple forms
 *              */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace EquipmentInventory
{
    public partial class frmCheckItemOut : Form
    {
        //declaring variables
        private string email;
        private CheckOutItemCollection items = new CheckOutItemCollection();
        private CheckOutItem emp;

        private bool isEmpty;
        public frmCheckItemOut()
        {
            InitializeComponent();
            //initializing variables
            radYes.Checked = true;
            //real size
            //this.Size = new Size(369,561);
            this.Size = new Size(369, 314);
            // this.panCheck.Visible = false;
            isEmpty = false;
            
            items.ReadFile();
        }

        private void radYes_CheckedChanged(object sender, EventArgs e)
        {
            //when the yes radio button is checked 
            //the email text box is now read only
            txtEmpEmail.ReadOnly = true;
            //this code stores and trims the textbox and replaces spaces with periods, so that there are no spaces in a email
            email = txtEmpFirst.Text.Trim().Replace(' ', '.') + "." + txtEmpLast.Text.Trim().Replace(' ', '.') + "@rrcc.edu";
            //outputing email to the screen.
            txtEmpEmail.Text = email;
        }

        private void radNo_CheckedChanged(object sender, EventArgs e)
        {
            //when the no radio button is checked
            //it makes the email textbox not read only
            txtEmpEmail.ReadOnly = false;
            //sets focus
            txtEmpEmail.Focus();
            //selects all
            txtEmpEmail.SelectAll();
            //sets email to nothing
            email = "";
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            //clears everything
            txtSNum.Clear();
            txtEmpFirst.Clear();
            txtEmpLast.Clear();
            radSoft.Enabled = true;
            radEquip.Enabled = true;
            txtEmpEmail.Clear();
            
            radNo.Checked = false;
            radYes.Checked = true;
            txtEmpEmail.ReadOnly = true;
            email = "@rrcc.edu";
            txtSNum.Focus();
            radEquip.Checked = false;
            radSoft.Checked = false;
            //radInvent.Checked = false;
            this.Size = new Size(369, 314);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Closes the application
            items.WriteFile();
            this.Close();

        }



        private void txtEmpLast_Leave(object sender, EventArgs e)
        {
            //sets what is in the first and last name textboxes and trims it as well.
            email = txtEmpFirst.Text.Trim().Replace(" ", "") + "." + txtEmpLast.Text.Trim().Replace(" ", "") + "@rrcc.edu";
            //displays it to the screen
            txtEmpEmail.Text = email;
        }

        private void txtEmpFirst_KeyPress(object sender, KeyPressEventArgs e)
        {
            //making sure there are no numbers or special characters
            if (!(Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtEmpLast_KeyPress(object sender, KeyPressEventArgs e)
        {
            //making sure there are no numbers or special characters
            if (!(Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }



        private void txtEmpEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            //making sure that there are no special characters in the email
            int asciiCode = Convert.ToInt32(e.KeyChar);
            if (!((asciiCode >= 48 && asciiCode <= 57) || (asciiCode >= 65 && asciiCode <= 90) ||
                (asciiCode >= 97 && asciiCode <= 122)
                || asciiCode == 64 || asciiCode == 95 || asciiCode == 46 || asciiCode == 45 || asciiCode == 8))
            {
                e.Handled = true;
            }
        }

        private void radEquip_CheckedChanged(object sender, EventArgs e)
        {
            //setting all of the labels to where they need to be
            panCheck.lblEquipItem.Visible = true;
            panCheck.lblEquip.Visible = true;
            panCheck.lblSoftItem.Visible = false;
            panCheck.lblSoft.Visible = false;
            panCheck.lblTagNum.Text = "Tag Number";
            Match match;
            //having a pettern match for the S Number
            match = Regex.Match(txtSNum.ToString(), @"S(\d{8,8})", RegexOptions.IgnoreCase);
            if (radEquip.Checked)
            {
                if (!match.Success)
                {
                    isEmpty = true;
                    radEquip.Checked = false;
                    MessageBox.Show("Please enter your S# with 8 digits.");
                    //sets the focus
                    txtSNum.Focus();
                    //selects all
                    txtSNum.SelectAll();
                    return;
                }
                else if (txtSNum.Text.Length > 9)
                {
                    isEmpty = true;
                    radEquip.Checked = false;
                    MessageBox.Show("Please enter your S# with 8 digits.");
                    //sets the focus
                    txtSNum.Focus();
                    //selects all
                    txtSNum.SelectAll();
                    return;
                }
                if (txtSNum.Text == "")
                {
                    isEmpty = true;
                    radEquip.Checked = false;
                    //if the txtSNum textbox doesn't have anything
                    MessageBox.Show("Please enter your S#.");
                    //sets the focus
                    txtSNum.Focus();
                    //selects all
                    txtSNum.SelectAll();
                    return;
                }
                //but if there is no employee first name
                if (txtEmpFirst.Text == "")
                {
                    //then a flag will set off
                    isEmpty = true;
                    radEquip.Checked = false;
                    //and opens up a message box to tell the user
                    //to enter their first name in the textbox.
                    MessageBox.Show("Please enter your first name.");
                    //sets the focus
                    txtEmpFirst.Focus();
                    //selects all
                    txtEmpFirst.SelectAll();
                    //returns
                    return;
                }
                //but if there is no employee last name
                if (txtEmpLast.Text == "")
                {
                    //then a flag will set off.
                    isEmpty = true;
                    radEquip.Checked = false;
                    //and opens up a message box to tell the user 
                    //to enter their last name in the textbox
                    MessageBox.Show("Please enter your last name.");
                    //sets the focus
                    txtEmpLast.Focus();
                    //selects all
                    txtEmpLast.SelectAll();
                    return;
                }
                //but if there is no email in the textbox
                if (txtEmpEmail.Text == "")
                {
                    //then a flag will set off
                    isEmpty = true;
                    radEquip.Checked = false;
                    //and opens up a message box to tell the user 
                    //to enter their email in the textbox
                    MessageBox.Show("Please enter your email.");
                    //sets the focus
                    txtEmpEmail.Focus();
                    //selects all
                    txtEmpEmail.SelectAll();
                    return;
                }
                radSoft.Enabled = false;
                this.Size = new Size(369, 575);
            }
            
            

        }

        private void radSoft_CheckedChanged(object sender, EventArgs e)
        {
            //setting all of the labels to where they need to be
            panCheck.lblSoftItem.Visible = true;
            panCheck.lblSoft.Visible = true;
            panCheck.lblEquip.Visible = false;
            panCheck.lblEquipItem.Visible = false;
            panCheck.lblTagNum.Text = "Software Version";
            Match match;
            //having a pettern match for the S Number
            match = Regex.Match(txtSNum.ToString(), @"S(\d{8,8})", RegexOptions.IgnoreCase);
            if (radSoft.Checked)
            {
                if (!match.Success)
                {
                    isEmpty = true;
                    radSoft.Checked = false;
                    MessageBox.Show("Please enter your S# with 8 digits.");
                    //sets the focus
                    txtSNum.Focus();
                    //selects all
                    txtSNum.SelectAll();
                    return;
                }
                else if (txtSNum.Text.Length > 9)
                {
                    isEmpty = true;
                    radSoft.Checked = false;
                    MessageBox.Show("Please enter your S# with 8 digits.");
                    //sets the focus
                    txtSNum.Focus();
                    //selects all
                    txtSNum.SelectAll();
                    return;
                }
                if (txtSNum.Text == "")
                {
                    isEmpty = true;
                    radSoft.Checked = false;
                    //if the txtSNum textbox doesn't have anything
                    MessageBox.Show("Please enter your S#.");
                    //sets the focus
                    txtSNum.Focus();
                    //selects all
                    txtSNum.SelectAll();
                    return;
                }
                //but if there is no employee first name
                if (txtEmpFirst.Text == "")
                {
                    //then a flag will set off
                    isEmpty = true;
                    radSoft.Checked = false;
                    //and opens up a message box to tell the user
                    //to enter their first name in the textbox.
                    MessageBox.Show("Please enter your first name.");
                    //sets the focus
                    txtEmpFirst.Focus();
                    //selects all
                    txtEmpFirst.SelectAll();
                    //returns
                    return;
                }
                //but if there is no employee last name
                if (txtEmpLast.Text == "")
                {
                    //then a flag will set off.
                    isEmpty = true;
                    radSoft.Checked = false;
                    //and opens up a message box to tell the user 
                    //to enter their last name in the textbox
                    MessageBox.Show("Please enter your last name.");
                    //sets the focus
                    txtEmpLast.Focus();
                    //selects all
                    txtEmpLast.SelectAll();
                    return;
                }
                //but if there is no email in the textbox
                if (txtEmpEmail.Text == "")
                {
                    //then a flag will set off
                    isEmpty = true;
                    radSoft.Checked = false;
                    //and opens up a message box to tell the user 
                    //to enter their email in the textbox
                    MessageBox.Show("Please enter your email.");
                    //sets the focus
                    txtEmpEmail.Focus();
                    //selects all
                    txtEmpEmail.SelectAll();
                    return;
                }
                this.Size = new Size(369, 575);
                radEquip.Enabled = false;
            }
        }

        private void radInvent_CheckedChanged(object sender, EventArgs e)
        {
            if (radInvent.Checked)
            {
                radInvent.Checked = false;
                //clears everything
                txtSNum.Clear();
                txtEmpFirst.Clear();
                txtEmpLast.Clear();
                radSoft.Enabled = true;
                radEquip.Enabled = true;
                txtEmpEmail.Clear();
                
                radNo.Checked = false;
                radYes.Checked = true;
                txtEmpEmail.ReadOnly = true;
                email = "@rrcc.edu";
                txtSNum.Focus();
                radEquip.Checked = false;
                radSoft.Checked = false;
                chkAccept.Checked = false;
                this.Size = new Size(369, 314);
                radSoft.Enabled = true;
                radEquip.Enabled = true;
                this.Visible = false;
                frmEquipmentInventory frm = new frmEquipmentInventory(this, items);
                frm.Show();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //if the submit button is clicked
            //if the accept check box is checked
            Match match;
            if (chkAccept.Checked)
            {
                //having a pettern match for the S Number
                match = Regex.Match(txtSNum.ToString(), @"S(\d{8,8})", RegexOptions.IgnoreCase);
                if (!match.Success)
                {
                    isEmpty = true;
                    MessageBox.Show("Please enter your S# with 8 digits.");
                    //sets the focus
                    txtSNum.Focus();
                    //selects all
                    txtSNum.SelectAll();
                    return;
                }
                else if (txtSNum.Text.Length > 9)
                {
                    isEmpty = true;
                    MessageBox.Show("Please enter your S# with 8 digits.");
                    //sets the focus
                    txtSNum.Focus();
                    //selects all
                    txtSNum.SelectAll();
                    return;
                }
                if (txtSNum.Text == "")
                {
                    isEmpty = true;
                    //if the txtSNum textbox doesn't have anything
                    MessageBox.Show("Please enter your S#.");
                    //sets the focus
                    txtSNum.Focus();
                    //selects all
                    txtSNum.SelectAll();
                    return;
                }
                //but if there is no employee first name
                if (txtEmpFirst.Text == "")
                {
                    //then a flag will set off
                    isEmpty = true;
                    //and opens up a message box to tell the user
                    //to enter their first name in the textbox.
                    MessageBox.Show("Please enter your first name.");
                    //sets the focus
                    txtEmpFirst.Focus();
                    //selects all
                    txtEmpFirst.SelectAll();
                    //returns
                    return;
                }
                //but if there is no employee last name
                if (txtEmpLast.Text == "")
                {
                    //then a flag will set off.
                    isEmpty = true;
                    //and opens up a message box to tell the user 
                    //to enter their last name in the textbox
                    MessageBox.Show("Please enter your last name.");
                    //sets the focus
                    txtEmpLast.Focus();
                    //selects all
                    txtEmpLast.SelectAll();
                    return;
                }
                //but if there is no email in the textbox
                if (txtEmpEmail.Text == "")
                {
                    //then a flag will set off
                    isEmpty = true;
                    //and opens up a message box to tell the user 
                    //to enter their email in the textbox
                    MessageBox.Show("Please enter your email.");
                    //sets the focus
                    txtEmpEmail.Focus();
                    //selects all
                    txtEmpEmail.SelectAll();
                    return;
                }

                //but if there is no text in the textbox
                if (panCheck.txtItemInfo.Text == "")
                {
                    //then a flag will set off
                    isEmpty = true;
                    //and opens up a message box to tell the user 
                    //to enter their item information in the textbox
                    MessageBox.Show("Please enter your item information.");
                    //sets the focus
                    panCheck.txtItemInfo.Focus();
                    //selects all
                    panCheck.txtItemInfo.SelectAll();
                    return;
                }
                //but if there is no tag number
                if (panCheck.txtTagNum.Text == "")
                {
                    isEmpty = true;
                    //and opens up a message box to tell the user 
                    //to enter their tag number in the textbox
                    MessageBox.Show("Please enter your tag number.");
                    //sets the focus
                    panCheck.txtTagNum.Focus();
                    //selects all
                    panCheck.txtTagNum.SelectAll();
                    return;
                }

                //but if there is no date
                if (panCheck.txtDateCheckOut.Text == "")
                {
                    //then a flag will set off
                    isEmpty = true;
                    //and opens up a message box to tell the user 
                    //to enter their date of check out in the textbox
                    MessageBox.Show("Please enter the date of check out.");
                    //sets the focus
                    panCheck.txtDateCheckOut.Focus();
                    //selects all
                    panCheck.txtDateCheckOut.SelectAll();
                    return;
                }
                //if all is well 
                if (isEmpty == false)
                {
                    //initializing a new checkoutitem
                    emp = new CheckOutItem();
                    //adding the text from the textboxes into the items in checkoutitem
                    emp.EmpSNum = txtSNum.Text;
                    emp.EmpFirst = txtEmpFirst.Text;
                    emp.EmpLast = txtEmpLast.Text;
                    emp.EmpEmail = txtEmpEmail.Text;
                    emp.EmpItem = panCheck.txtItemInfo.Text;
                    emp.EmpTagNum = panCheck.txtTagNum.Text;
                    emp.EmpDate = panCheck.txtDateCheckOut.Text;
                    chkAccept.Checked = false;
                    //adding all the items
                    items.Add(emp);
                    //sorting all the items by the S Number
                    items.sort();
                    txtSNum.Clear();
                    txtEmpFirst.Clear();
                    txtEmpLast.Clear();
                    panCheck.txtItemInfo.Clear();
                    panCheck.txtTagNum.Clear();
                    panCheck.txtDateCheckOut.Clear();
                    radSoft.Enabled = true;
                    radEquip.Enabled = true;
                    txtEmpEmail.Clear();
                    
                    radNo.Checked = false;
                    radYes.Checked = true;
                    txtEmpEmail.ReadOnly = true;
                    email = "@rrcc.edu";
                    txtSNum.Focus();
                    radEquip.Checked = false;
                    radSoft.Checked = false;
                    radInvent.Checked = false;
                    
                }
                this.Size = new Size(369, 314);
                //after that isEmpty is set to false again
                isEmpty = false;
                //clears everything
                
            }
            //if they didn't check the accept checkbox 
            else if (chkAccept.Checked == false)
            {
                //then a message box will show and make sure that the check box is checked
                MessageBox.Show("Please check Accept Terms of \n User Agreement");
                //sets the focus
                chkAccept.Focus();
            }
        }

        private void frmCheckItemOut_FormClosing(object sender, FormClosingEventArgs e)
        {
            items.WriteFile();
        }
    }
}
