using RBSoft.Plugin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBSoft.Forms
{
    public partial class frmAccounts : Form
    {

        string date = DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year;
        string time = DateTime.Now.Hour + "." + DateTime.Now.Minute + "." + DateTime.Now.Second;
        //string MatchFound;
        public string Bill_no_var;
        public string val;
        string CheckValAmountTemp = "0";
        string CheckValAdvanceTemp = "0";

        #region frm Setup
        public frmAccounts()
        {
            InitializeComponent();
            grpAccount.Hide();
            txtPay.ReadOnly = true;
            txtDate.Text = date;
            btnCalculate.IsAccessible = false;
            btnRecordAndPrint.IsAccessible = false;
            btnPrintOnly.IsAccessible = false;
            btnGetAmountCal.IsAccessible = true;

        }
        #endregion

        


        #region Process Button
        private void btn_Proceed(object sender, EventArgs e)
        {
            btnCalculate.IsAccessible = false;
            btnRecordAndPrint.IsAccessible = false;
            btnPrintOnly.IsAccessible = false;
            txtPay.ReadOnly = true;
            btnGetAmountCal.IsAccessible = true;
            SearchMemberByID();
        }
        #endregion


        #region Search BillNO and Get Data
        /// <summary>
        /// Search bill record and ask for get those data 
        /// </summary>
        public void SearchMemberByID()
        {
            SqlConnection sql = new SqlConnection(PlugInCode.GetConnection.ConnString());
            sql.Close();
            sql.Open();
            Bill_no_var = billno.Text.ToString();

            SqlDataAdapter adapt = new SqlDataAdapter("select * from tblPrintDetails where BillNo='" + Bill_no_var + "'", sql);
            DataTable dt = new DataTable();
            adapt.Fill(dt);


            if (dt.Rows.Count > 0)
            {
                sql.Close();
                GetDataToTextField(Bill_no_var);
            }
            else
            {
                MessageBox.Show("Bill Not Found");
            }

        }
        #endregion
        

        #region Collect data to the text box and show to the accountent
        /// <summary>
        /// Collect data of the current Bill No 
        /// </summary>
        /// <param name="value"></param>
        // Get Member Data to the Text Field 
        public void GetDataToTextField(string value)
        {
            
            
            SqlConnection sql = new SqlConnection(PlugInCode.GetConnection.ConnString());
            sql.Close();
            DataTable dt = new DataTable();
            sql.Open();
            SqlDataReader myReaderw = null;
           

            SqlCommand myCommand = new SqlCommand("select * from dbo.tblPerson where tblPerson.BillNo ='" + value + "'", sql);
            
            myReaderw = myCommand.ExecuteReader();

            while (myReaderw.Read())
            {

                string val1 = myReaderw["PersonName"].ToString();
                string val2 = myReaderw["PersonPhnNo"].ToString();
                string val3 = myReaderw["PersonAddress"].ToString();

                txtClientName.Text = val1;
                txtClientPhnNo.Text = val2;
                txtClientAddress.Text = val3;

                // Here Never disconnect sql
            }

            sql.Close();
            sql.Open();
            //Check wither he before instart data or not
            SqlDataReader myReaderCheck = null;
            SqlCommand myCommandCheck = new SqlCommand("select * from dbo.tblaccount where tblaccount.BillNo ='" + value + "'", sql);

            myReaderCheck = myCommandCheck.ExecuteReader();
           
            while (myReaderCheck.Read())
            {

                string CheckValAmount = myReaderCheck["tkAmount"].ToString();
                string CheckValAdvance = myReaderCheck["tkPayment"].ToString();
                CheckValAmountTemp = CheckValAmount;
                CheckValAdvanceTemp = CheckValAdvance;

                MessageBox.Show(CheckValAdvanceTemp.ToString());
            }

            try
            {

                sql.Close();
                myReaderw.Close();
                sql.Open();
                SqlDataAdapter adapt1 = new SqlDataAdapter("select MediaType,Hight,Wide,Sft,Qunty,Filenames from tblPrintDetails where tblPrintDetails.BillNo  ='" + value + "'", sql);
                DataTable dt2 = new DataTable();
                adapt1.Fill(dt2);
                ShowTheOrder.DataSource = dt2;

                sql.Close();
              }
              catch (Exception ex)
              {
                  MessageBox.Show(ex.Message, "Error");
              }

            
                sql.Close();
                grpAccount.Show();
        }



        #endregion


        #region Sft Get from Account
        //Sft get Done
        public int AmountFromSft ()
        {
            //string temp;
            string bill = billno.Text.ToString();
            SqlConnection sql = new SqlConnection(PlugInCode.GetConnection.ConnString());
            sql.Close();
            DataTable dt = new DataTable();
            sql.Open();
            SqlDataReader myReaderw = null;

            //SqlCommand myCommand = new SqlCommand("select * from dbo.tblPrintDetails where tblPrintDetails.BillNo ='" + bill + "'", sql);
            SqlCommand myCommand = new SqlCommand("SELECT * FROM dbo.tblPerson , dbo.tblPrintDetails where tblPrintDetails.BillNo = '"+bill+"' and tblPrintDetails.BillNo = tblPerson.BillNo", sql);

            myReaderw = myCommand.ExecuteReader();



            while (myReaderw.Read())
            {

                string val1 = myReaderw["Sft"].ToString();
                val = val1;
                
            }

            //MessageBox.Show(val.ToString());
            string txtboxamount = txtPriceValue.Text.ToString();
            int parseToint;
            int txtboxValue;
            int.TryParse(val, out parseToint);

            int.TryParse(txtboxamount, out txtboxValue);

            int calcluate = txtboxValue * parseToint;


            return calcluate;
        }
        #endregion



        private void btnGetAmount(object sender, EventArgs e)
        {
            txtPay.ReadOnly = false;
            txtAmount.Text = AmountFromSft().ToString();
            this.IsAccessible = false;
            btnCalculate.IsAccessible = true;
            btnRecordAndPrint.IsAccessible = false;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

        }
    }
}
