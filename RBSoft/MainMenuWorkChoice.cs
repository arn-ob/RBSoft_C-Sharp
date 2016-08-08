using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBSoft
{
    public partial class MainMenuWorkChoice : Form
    {
        public MainMenuWorkChoice()
        {
            InitializeComponent();
        }

        private void btnWorkOder(object sender, EventArgs e)
        {
            Forms.frmWorkOder workoder = new Forms.frmWorkOder();
            this.Hide();
            workoder.Show();
        }

        private void btnSearch(object sender, EventArgs e)
        {
            Forms.frmSearchData workoder = new Forms.frmSearchData();
            this.Hide();
            workoder.Show();
        }

        private void btnlogOut(object sender, EventArgs e)
        {
            MainWindow loginMenu = new MainWindow();
            this.Hide();
            loginMenu.Show();
            this.Close();
            // Sql script to store log out time to store datebase <<<<<<<<<<<<<< Give it 

          
        }
    }
}
