using RBSoft.Plugin;
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
    public partial class frmWorkOder : Form
    {
        #region Global Variable 

        string sysID = "Null";
        string BillNo = "Null";


        #endregion //End of global Variable list


        #region Frm Setup Control
        // Frm Setup
        public frmWorkOder()
        {
            InitializeComponent();

        }

        #endregion //...............................


        #region Generate a Unc Key For Store a Data
        /// <summary>
        /// Its Describe as a uniqe key so that data can store safely
        /// its retrun a billID and a SYSID and a SUBBillID
        /// </summary>
        /// <returns></returns>
        //string TodayDay = DateTime.Now.Day.ToString();
        //string Todaymonth = DateTime.Now.Month.ToString();
        public static string getSysID()
        {
            string sysID = "SYSID-" + PlugInCode.GetUniqueKey(3) + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Second.ToString();
            return sysID;
        }
        public static string getBillID()
        {
            string BillNo = "Bill-" + PlugInCode.GetUniqueKey(3) + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Second.ToString();
            return BillNo;
        }

        public static string getSubBillID()
        {
            string BillNo = "SubBill-" + PlugInCode.GetUniqueKey(3) + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Second.ToString();
            return BillNo;
        }




        #endregion Done Define



        #region Not Needed Function
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmWorkOder_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //int val1 = 0;
            //int val2 = 0;
            //int.TryParse(txtPrice.Text, out val1);
            //int.TryParse(txtSaleQty.Text, out val2);
            //int I = (val1 * val2);
            //txtTotalAmount.Text = I.ToString();
        }
        #endregion

        private void ClearEveryThing(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtAddress.Text = "";
            txtMobile.Text = "";
            txtHight.Text = "";
            txtQnt.Text = "";
            txtSft.Text = "";
            txtWide.Text = "";
        }
    }
}
