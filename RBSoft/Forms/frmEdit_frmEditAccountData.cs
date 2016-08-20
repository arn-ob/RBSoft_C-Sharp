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
    public partial class frmEdit_frmEditAccountData : Form
    {
        public frmEdit_frmEditAccountData()
        {
            InitializeComponent();
        }

        private void btn_Search_By_BillNo(object sender, EventArgs e)
        {
            if(txtSearchKey.Text.ToString() != "")
            {
                try
                {

                    SqlConnection sql = new SqlConnection(PlugInCode.GetConnection.ConnString());
                    sql.Close();
                    DataTable dt = new DataTable();
                    sql.Open();
                    SqlDataReader myReaderw = null;


                    SqlCommand myCommand = new SqlCommand("select * from dbo.tblPerson, dbo.tblPrintDetails, dbo.tblaccount where tblPerson.BillNo=tblaccount.BillNo and tblPrintDetails.BillNo=tblaccount.BillNo and tblaccount.BillNo = '" + txtSearchKey.Text.ToString() + "'", sql);

                    myReaderw = myCommand.ExecuteReader();

                    while (myReaderw.Read())
                    {

                        string val1 = myReaderw["PersonName"].ToString();
                        string val2 = myReaderw["PersonPhnNo"].ToString();
                        string val3 = myReaderw["PersonAddress"].ToString();

                        string val4 = myReaderw["tkPerSft"].ToString();
                        string val5 = myReaderw["tkAmount"].ToString();
                        string val6 = myReaderw["tkPayment"].ToString();
                        string val7 = myReaderw["tkDue"].ToString();
                        string val8 = myReaderw["LastUpdate"].ToString();

                        txtName.Text = val1;
                        txtPhoneNo.Text = val2;
                        txtAddress.Text = val3;
                        txtPreAmount.Text = val5;
                        txtPerPay.Text = val6;
                        txtPreDue.Text = val7;
                        txtLastUpdate.Text = val8;
                        txtPrvSft.Text = val4;

                    }

                    sql.Close();
                }
                catch
                {
                    MessageBox.Show("Can not connected to DataBase");
                }

                //Search buy History

                try
                {
                    SqlConnection sql = new SqlConnection(PlugInCode.GetConnection.ConnString());
                    sql.Open();
                    ShowBuyData.Show();
                    string sqlque = "SELECT tblPrintDetails.BillNo,tblPrintDetails.SubBillNo,tblPrintDetails.MediaType,tblPrintDetails.Sft, tblPrintDetails.Qunty, tblPrintDetails.PrintStatus from tblPerson , tblPrintDetails WHERE tblPerson.BillNo = tblPrintDetails.BillNo and tblPerson.BillNo= '" + txtSearchKey.Text.ToString() + "'";

                    SqlDataAdapter adapt = new SqlDataAdapter(sqlque, sql);
                    DataTable dtclient = new DataTable();
                    adapt.Fill(dtclient);
                    ShowBuyData.DataSource = dtclient;
                    sql.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Not Succesfull " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else{

                MessageBox.Show("Enter BillNo");
            }

        }
    }
}
