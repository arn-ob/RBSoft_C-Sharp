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
    }
}
