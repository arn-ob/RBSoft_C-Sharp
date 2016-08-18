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
    public partial class frmAccount : Form
    {

        string date = DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year;
        string time = DateTime.Now.Hour + "." + DateTime.Now.Minute + "." + DateTime.Now.Second;
        //string MatchFound;
        string Bill_no_var;


        #region frm Setup
        public frmAccount()
        {
            InitializeComponent();
            grpAccount.Hide();
        }
        #endregion

        #region Process Button
        private void btn_Proceed(object sender, EventArgs e)
        {
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










    }
}
