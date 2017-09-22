using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaveO_Sullivan
{
    public partial class frmSupplierNew : Form
    {
        public frmSupplierNew()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
           // bool valid = true; ;

            //Validate Data
            if(txtSuppName.Text.Equals(""))
            {
                MessageBox.Show("Supplier Name cannot be empty!", "Register Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // valid = false;
                txtSuppName.Focus();
                return;
            }

            //Set Default Data

            //save data in supplier file

            //display confirmation message
           // if(valid==true)
                  MessageBox.Show("Supplier has been added. Thank you.", "Register Confirmatiion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            txtSuppName.Text = "";
            textBox1.Text = "013";
            newSuppContact.Text = "";
            txtSuppName.Focus();
        }

        private void regMnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
