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
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void btn_Show_User_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under Dev");
        }

        private void btn_Delete_User_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under Dev");
        }

        private void btn_Edit_User_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under Dev");
        }

        private void btnCreate_User_Click(object sender, EventArgs e)
        {
            Forms.FrmEmployee_CreateUser newUser = new FrmEmployee_CreateUser();
            this.Hide();
            newUser.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenuWorkChoice mainMenu = new MainMenuWorkChoice();
            this.Hide();
            mainMenu.Show();
        }
    }
}
