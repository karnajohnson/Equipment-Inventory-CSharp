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

namespace EquipmentInventory
{
    public partial class frmEquipmentInventory : Form
    {
        //fields
        private frmCheckItemOut mainForm;
        CheckOutItemCollection allCheck = new CheckOutItemCollection();
        public frmEquipmentInventory(frmCheckItemOut formItem, CheckOutItemCollection check)
        {
            InitializeComponent();
            mainForm = formItem;
            
            //declaring i as 0
            int i = 0;
            //making the checkoutitem item equal the item in the collection at i
            CheckOutItem item = check.objectat(i);
            if (check.count() == 0)
                return;
            //using a for loop for the nodes for the treeview
            //creating new root node
            TreeNode root = new TreeNode();
            //creating new child node
            TreeNode child = new TreeNode();
            //creating new grandchild node
            TreeNode gChild = new TreeNode();
            //adding the text from the textboxes to the root, child, gChild
            root.Text = item.EmpSNumFirstLast();
            child.Text = item.EmpItemTag();
            gChild.Text = item.EmpDate;
            //adding the root to the treeview
            treeEmp.Nodes.Add(root);
            //adding the child to the root
            root.Nodes.Add(child);
            //adding the grandchild to the child
            child.Nodes.Add(gChild); 
            for ( i = 1; i < check.count(); i++)
            {
                 //making it so that the checkoutitem is equal to the list of items
                item = check.objectat(i);
                if (root.Text != item.EmpSNumFirstLast() && check.count() > 0)
                {//if the root text doesn't equal the s num text 
                    root = new TreeNode();
                    child = new TreeNode();
                    //creating new grandchild node
                    gChild = new TreeNode();
                    root.Text = item.EmpSNumFirstLast();
                    child.Text = item.EmpItemTag();
                    gChild.Text = item.EmpDate;
                    //adding the root to the treeview
                    treeEmp.Nodes.Add(root);
                    //adding the child to the root
                    root.Nodes.Add(child);
                    //adding the grandchild to the child
                    child.Nodes.Add(gChild);
                   // allCheck.WriteFile(root.Text);
                   // allCheck.WriteFile(child.Text);
                    //allCheck.WriteFile(gChild.Text);
                }
                else if (child.Text != item.EmpItemTag() && check.count() > 0)
                    //if the child text doesn't equal the item des and tag num
                {
                    child = new TreeNode();
                    gChild = new TreeNode();
                    child.Text = item.EmpItemTag();
                    gChild.Text = item.EmpDate;
                    //adding the child to the root
                    root.Nodes.Add(child);
                    //adding the grandchild to the child
                    child.Nodes.Add(gChild);
                }
                else if (gChild.Text != item.EmpDate && check.count() > 0) 
                    // if the text doesn't equal the text in the date text 
                {
                    //creating new grandchild node
                    gChild = new TreeNode();
                    //equaling the text of the gChild to the text in the item
                    gChild.Text = item.EmpDate;
                    //adding the grandchild to the child
                    child.Nodes.Add(gChild);
                }    
            }
        }
        
        private void btnBack_Click(object sender, EventArgs e)
        {
            //making it so that the forms can go back and forth
            this.Visible = false;
            mainForm.Visible = true;
            //allCheck.WriteFile();
        }

        private void frmEquipmentInventory_FormClosing(object sender, FormClosingEventArgs e)
        {
            allCheck.WriteFile();
            //having the current form close
            mainForm.Close(); 
        }  

    }
}
