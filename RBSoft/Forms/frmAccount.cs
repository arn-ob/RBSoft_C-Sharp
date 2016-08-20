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
        public string SftValue = "0";
        static string  CheckValAmountTemp = "0";
        static string  CheckValPayTemp = "0";
        static string CheckValDueTemp = "0";
        static string CheckDateTemp = "0";

        #region frm Setup
        public frmAccounts()
        {
            InitializeComponent();
            grpAccount.Hide();
            txtPay.ReadOnly = true;
            txtDate.Text = "Present Date :" + date.ToString();
            btnCalculate.Hide();
            btnRecordAndPrint.Hide();
            btnPrintOnly.Hide();
            btnGetAmountCal.Hide();
            Bill_no_var = billno.Text.ToString();
            //txtAmount.Text = "Click Calculate";

        }
        #endregion

        


        #region Process Button
        private void btn_Proceed(object sender, EventArgs e)
        {
            //txtAmount.Text = "Click Calculate";
            txtPriceValue.Text = "20";
            SftValue = "0";
            txtDate.Text = "Present Date :" + date.ToString();
            txtPay.ReadOnly = true;
            SearchMemberByID();
            CheckDBDATA();
            txtPriceValue.ReadOnly = false;
            

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
                GetData.Hide();
            }
            else
            {
                MessageBox.Show("Bill Not Found");
                GetData.Show();
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


            // !!!!!!!!!!!!!!!!!!!!!!!!!!!!! Wrok start From Here
            //Check wither he before instart data or not

            SqlDataReader myReaderCheck = null;
            SqlCommand myCommandCheck = new SqlCommand("select * from dbo.tblaccount where tblaccount.BillNo ='" + value + "'", sql);

            myReaderCheck = myCommandCheck.ExecuteReader();
           
            while (myReaderCheck.Read())
            {

                string CheckValAmount = myReaderCheck["tkAmount"].ToString();
                string CheckValPay = myReaderCheck["tkPayment"].ToString();
                string CheckValDue = myReaderCheck["tkDue"].ToString();
                string CheckDate = myReaderCheck["PresentDate"].ToString();
                CheckValAmountTemp = CheckValAmount;
                CheckValPayTemp = CheckValPay;
                CheckDateTemp = CheckDate;
                CheckValDueTemp = CheckValDue;
                //MessageBox.Show(CheckValAdvanceTemp.ToString());
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


        #region Sft Get from Account ... Problem Get (When Multile Sft Come What i do)
        //Sft get Done
        public int AmountFromSft ()
        {
            //string temp;
            string bill = billno.Text.ToString();
           // SqlConnection con = new SqlConnection(PlugInCode.GetConnection.ConnString());

            #region old Sft find code
            //sql.Close();
            //DataTable dt = new DataTable();
            //sql.Open();
            //SqlDataReader myReaderw = null;

            ////SqlCommand myCommand = new SqlCommand("select * from dbo.tblPrintDetails where tblPrintDetails.BillNo ='" + bill + "'", sql);
            //SqlCommand myCommand = new SqlCommand("SELECT sum(convert(int,sft)) FROM dbo.tblPerson , dbo.tblPrintDetails where tblPrintDetails.BillNo = '" + bill+"' and tblPrintDetails.BillNo = tblPerson.BillNo", sql);

            //myReaderw = myCommand.ExecuteReader();



            //while (myReaderw.Read())
            //{

            //    string val1 = myReaderw["sum(convert(int,sft))"].ToString();
            //    val = val1;
            //    MessageBox.Show(val1);
            //}
            #endregion

            #region TryOld Code
            //SqlCommand testCMD = new SqlCommand("dbo.TestProcedure2", sql);
            //testCMD.CommandType = CommandType.StoredProcedure;

            //SqlParameter RetVal = testCMD.Parameters.Add ("RetVal", SqlDbType.VarChar);

            //RetVal.Direction = ParameterDirection.ReturnValue;

            //SqlParameter IdIn = testCMD.Parameters.Add("@BillNO", SqlDbType.VarChar, 11);
            //IdIn.Direction = ParameterDirection.Input;
            ////SqlParameter NumTitles = testCMD.Parameters.Add("@total_Sft", SqlDbType.VarChar, 20);
            ////NumTitles.Direction = ParameterDirection.Output;

            //IdIn.Value = bill.ToString();
            //sql.Open();
            //string strCount = testCMD.ExecuteScalar().ToString();
            //MessageBox.Show(strCount);
            //MessageBox.Show(RetVal.Value.ToString());
            //SqlDataReader myReader = testCMD.ExecuteReader();
            //Console.WriteLine("Book Titles for this Author:");
            //while (myReader.Read())
            //{
            //    Console.WriteLine("{0}", myReader.GetString(2));
            //};
            //myReader.Close();
            //Console.WriteLine("Number of Rows: " + NumTitles.Value);
            //Console.WriteLine("Return Value: " + RetVal.Value);



            //SqlCommand cmd = new SqlCommand("GetSum", con);
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@BillNO", SqlDbType.VarChar).Value = bill.ToString();
            //SqlDataAdapter adp = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //try
            //{
            //    if (con.State == ConnectionState.Closed)
            //        con.Open();
            //    adp.Fill(dt);
            //    if (dt.Rows.Count > 0)
            //    {
            //        string ss = dt.Rows[0]..ToString();
            //        MessageBox.Show(ss);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Not Get");
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("Not Good");
            //}
            #endregion

            SqlConnection sql = new SqlConnection(PlugInCode.GetConnection.ConnString());
            sql.Close();
            sql.Open();


            SqlDataAdapter adapt = new SqlDataAdapter("SELECT  SUM(CONVERT(int,dbo.tblPrintDetails.Sft)) as sft FROM dbo.tblPrintDetails WHERE dbo.tblPrintDetails.BillNo = '" + bill + "'", sql);
            DataTable dt = new DataTable();
            adapt.Fill(dt);


            if (dt.Rows.Count > 0)
            {
                string ss = dt.Rows[0]["sft"].ToString();
                SftValue = ss;
                //MessageBox.Show(ss);
                sql.Close();

            }


                //MessageBox.Show(val.ToString());
                string txtboxamount = txtPriceValue.Text.ToString();
            int parseToint;
            int txtboxValue;

            int.TryParse(SftValue, out parseToint);

            int.TryParse(txtboxamount, out txtboxValue);

            int calcluate = txtboxValue * parseToint;


            return calcluate;
        }
        #endregion

        //Check is data Already insert !!!
        public void CheckDBDATA()
        {
            int ValOFTempAcmout;
            int.TryParse(CheckValAmountTemp, out ValOFTempAcmout);
            if (ValOFTempAcmout > 0)
            {
                txtAmount.Text = CheckValAmountTemp.ToString();
                txtPay.Text = CheckValPayTemp.ToString();
                txtDue.Text = CheckValDueTemp.ToString();
                txtDate.Text = "Data Stored in " + CheckDateTemp.ToString();
                btnCalculate.Hide();
                btnGetAmountCal.Hide();
                btnRecordAndPrint.Hide();
                MessageBox.Show("Recod Found");
                CheckValAmountTemp = "0";
                btnPrintOnly.Show();
                GetData.Hide();
            }
            else
            {
                txtDue.Text = "";
                txtDate.Text = "Present Date : " + date.ToString();
                txtAmount.Text = "Click Calculate";
                txtPay.Text = "";
                btnCalculate.Show();
                btnGetAmountCal.Show();
                //btnRecordAndPrint.Show();
                btnPrintOnly.Show();
            }
            
        }

        private void btnGetAmount(object sender, EventArgs e)
        {
            txtPay.ReadOnly = false;
            txtAmount.Text = AmountFromSft().ToString();
            this.IsAccessible = false;
            btnCalculate.IsAccessible = true;
            btnRecordAndPrint.IsAccessible = false;
            txtPriceValue.ReadOnly = true;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int valueofAmount , valueofPay , valueofDue;
            int.TryParse(txtAmount.Text.ToString(), out valueofAmount);
            int.TryParse(txtPay.Text.ToString(), out valueofPay);
            if( valueofAmount >= valueofPay )
            {
                valueofDue = valueofAmount - valueofPay;
                txtDue.Text = valueofDue.ToString();
            }else
            {
                txtPay.Text = "";
                MessageBox.Show("Amount is SMALLER then Payment");
            }
            btnRecordAndPrint.Show();
        }



        private void btnRecordDataAndPrint(object sender, EventArgs e)
        {
            string amountGet, paymentGet , dueGet , PerSFTGet;

            amountGet = txtAmount.Text.ToString();
            dueGet = txtDue.Text.ToString();
            paymentGet = txtPay.Text.ToString();
            PerSFTGet = txtPriceValue.Text.ToString();

            try
            {
                SqlConnection sql = new SqlConnection(PlugInCode.GetConnection.ConnString());
                SqlCommand CheckOUT = new SqlCommand();


                CheckOUT.CommandText = "INSERT INTO dbo.tblaccount(BillNo,tkAmount,tkPayment,tkDue,PresentDate,PresentTime,tkPerSft) VALUES (@BillNo, @tkAmount, @tkPayment,@tkDue,@PresentDate,@PresentTime,@tkPerSft)";

                CheckOUT.CommandType = CommandType.Text;
                CheckOUT.Connection = sql;


                CheckOUT.Parameters.AddWithValue("BillNo", Bill_no_var);
                CheckOUT.Parameters.AddWithValue("tkAmount", amountGet);
                CheckOUT.Parameters.AddWithValue("tkPayment", paymentGet);
                CheckOUT.Parameters.AddWithValue("tkDue", dueGet);
                CheckOUT.Parameters.AddWithValue("PresentDate", date);
                CheckOUT.Parameters.AddWithValue("PresentTime", time);
                CheckOUT.Parameters.AddWithValue("tkPerSft", PerSFTGet);

                sql.Open();
                CheckOUT.ExecuteNonQuery();
                sql.Close();
                MessageBox.Show("Data Recoreded");
            }
            catch
            {
                MessageBox.Show("Data Not Store Check Connection ");
            }
            reset();
        }


        public void reset()
        {
            txtClientName.Text = "No Date";
            txtClientPhnNo.Text = "No Date";
            txtClientAddress.Text = "No Date";
            ShowTheOrder.DataSource = null;
            ShowTheOrder.Rows.Clear();
            txtAmount.Text = "Click Calculate";
            txtPay.Text = "";
            txtDue.Text = "";
            billno.Text = "";
            txtDate.Text = "";
            GetData.Show();
        }

        private void btnReset(object sender, EventArgs e)
        {
            reset();
        }

        private void btnGoback_Click(object sender, EventArgs e)
        {
            MainMenuWorkChoice mainC = new MainMenuWorkChoice();
            this.Hide();
            mainC.Show();

            //Temp Code It must be remove 
            this.Close();
        }

        private void btnOnlyInvoice(object sender, EventArgs e)
        {
            MessageBox.Show("Not Accessible");
        }

        private void grpAccount_Enter(object sender, EventArgs e)
        {

        }
    }
}
