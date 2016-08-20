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
    }
}
