using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBSoft.Forms
{
    public partial class frmEdit : Form
    {
        public frmEdit()
        {
            InitializeComponent();
        }

        private void btn_EditClientDATA(object sender, EventArgs e)
        {
            Forms.frmEdit_frmEditClientData editClient = new frmEdit_frmEditClientData();
            this.Hide();
            editClient.Show();
        }

        private void GobackToMenuChoice(object sender, EventArgs e)
        {
            MainMenuWorkChoice gotoChoice = new MainMenuWorkChoice();
            this.Hide();
            gotoChoice.Show();
        }

        private void btneditAccount(object sender, EventArgs e)
        {
            Forms.frmEdit_frmEditAccountData editClient = new frmEdit_frmEditAccountData();
            this.Hide();
            editClient.Show();
        }

        public void makeRoleBasedWork()
        {
            if (MainMenuWorkChoice.EmpRole == "Developer")
            {
                //MessageBox.Show("Welcome Dev");
            }
            else if (MainMenuWorkChoice.EmpRole == "Admin")
            {
                //MessageBox.Show("Welcome Admin");
            }
            else if (MainMenuWorkChoice.EmpRole == "Designer")
            {
                btn_Edit_clientData.Show(); 

                btn_Account_Data.Hide(); 
                btn_Employee_Data.Hide(); 
                btn_print_Data.Show(); 

                
            }
            else if (MainMenuWorkChoice.EmpRole == "Printer")
            {
                btn_Edit_clientData.Hide(); 

                btn_Account_Data.Hide(); 
                btn_Employee_Data.Hide();
                btn_print_Data.Show(); 
            }
            else if (MainMenuWorkChoice.EmpRole == "Account")
            {
                btn_Edit_clientData.Show(); 

                btn_Account_Data.Show(); 
                btn_Employee_Data.Hide(); 
                btn_print_Data.Hide();
            }else
            {
                MessageBox.Show("Who Are U ?");
            }
        }

        private void btn_Employee_Data_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under Dev");
        }

        private void btn_print_Data_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under Dev");
        }
    }
}
