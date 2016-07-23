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
            BillNo = getBillID();
            sysID = getSysID();
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


        #region ClearEveryThing Button 
        /// <summary>
        /// Here Reset all the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        #endregion


        #region GoBack Button
        /// <summary>
        /// Button Go to the previwes Menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GoBack(object sender, EventArgs e)
        {
            MainWindow main = new MainWindow();
            //DataEntry.DataEntry de = new DataEntry.DataEntry();
            Forms.frmWorkOder frm1 = new Forms.frmWorkOder();
            this.Close();
            this.Hide();
            main.Show();
            //de.Show();
            //frm1.Show();
        }
        #endregion



        #region AtToPrint Button
        /// <summary>
        /// Here Add multiple item to the listView 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AtToPrint(object sender, EventArgs e)
        {
            string printType = MediaComBox.Text;
            string status = StatusComBox.Text;
            
            if (listView1.Items.Count == 0)
            {

                ListViewItem lst = new ListViewItem();
                lst.SubItems.Add(BillNo.ToString());
                lst.SubItems.Add(txtName.Text);
                lst.SubItems.Add(printType.ToString());
                lst.SubItems.Add(txtSft.Text);
                lst.SubItems.Add(txtQnt.Text);
                lst.SubItems.Add(status.ToString());

                listView1.Items.Add(lst);
                return;
            }

            //for (int j = 0; j <= listView1.Items.Count - 1; j++)
            //{
            //    if (listView1.Items[j].SubItems[1].Text == textBox1.Text)
            //    {
            //        listView1.Items[j].SubItems[1].Text = textBox1.Text;
            //        listView1.Items[j].SubItems[2].Text = textBox2.Text;
            //        return;

            //    }
            //}

            ListViewItem lst1 = new ListViewItem();

            lst1.SubItems.Add(BillNo.ToString());
            lst1.SubItems.Add(txtName.Text);
            lst1.SubItems.Add(printType.ToString());
            lst1.SubItems.Add(txtSft.Text);
            lst1.SubItems.Add(txtQnt.Text);
            lst1.SubItems.Add(status.ToString());

            listView1.Items.Add(lst1);
            return;

        }
        #endregion
    }
}
