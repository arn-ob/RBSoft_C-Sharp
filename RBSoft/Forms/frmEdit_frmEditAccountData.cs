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

        public static string PayTemp;
        public static string Pay;
        public static string DueTemp;
        public static string DuePay;
        public static string Temp;
        string date = DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year;
        string time = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;



        public frmEdit_frmEditAccountData()
        {
            InitializeComponent();
        }

        private void btn_Search_By_BillNo(object sender, EventArgs e)
        {

            SqlConnection sqlss = new SqlConnection(PlugInCode.GetConnection.ConnString());
            sqlss.Close();
            sqlss.Open();
            SqlDataAdapter adapts = new SqlDataAdapter("select BillNo from dbo.tblaccount where BillNo='" + txtSearchKey.Text.ToString() + "'", sqlss);
            DataTable dts = new DataTable();
            adapts.Fill(dts);

            if (dts.Rows.Count > 0)
            {
                sqlss.Close();

                if (txtSearchKey.Text.ToString() != "")
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
                            string val8 = myReaderw["LastUpdateDate"].ToString();

                            txtName.Text = val1;
                            txtPhoneNo.Text = val2;
                            txtAddress.Text = val3;
                            txtPreAmount.Text = val5;
                            txtPerPay.Text = val6;
                            txtPreDue.Text = val7;
                            txtLastUpdate.Text = val8;
                            txtPrvSft.Text = val4;

                            DueTemp = val7;
                            PayTemp = val6;



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
                }
                else
                {

                    MessageBox.Show("Enter BillNo");
                }
            }else
            {
                MessageBox.Show("Search Not Found");
            }

        }

        private void btn_updateAccountData(object sender, EventArgs e)
        {
            string NewPayGet = TxtNewPay.Text.ToString();

            int perseNewPay, perseDueTemp, persePayTemp;
            int.TryParse(NewPayGet, out perseNewPay);
            int.TryParse(DueTemp, out perseDueTemp);
            int.TryParse(PayTemp, out persePayTemp);


            SqlConnection sqlss = new SqlConnection(PlugInCode.GetConnection.ConnString());
            sqlss.Close();
            sqlss.Open();


            SqlDataAdapter adapt = new SqlDataAdapter("select BillNo from dbo.tblaccount where BillNo='" + txtSearchKey.Text.ToString() + "'", sqlss);
            DataTable dt = new DataTable();
            adapt.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                sqlss.Close();



                if (perseDueTemp < perseNewPay)
                {
                    MessageBox.Show("Today Pay is Bigger then Due Amount");
                }
                else
                {
                    int Due = perseDueTemp - perseNewPay;
                    int pay = persePayTemp + perseNewPay;

                    try
                    {
                        SqlConnection sql = new SqlConnection(PlugInCode.GetConnection.ConnString());
                        SqlCommand updateAccountDue = new SqlCommand();


                        updateAccountDue.CommandText = "UPDATE dbo.tblaccount SET tkPayment='" + pay.ToString() + "', tkDue='" + Due.ToString() + "' WHERE tblaccount.BillNo = '" + txtSearchKey.Text.ToString() + "'";

                        updateAccountDue.CommandType = CommandType.Text;
                        updateAccountDue.Connection = sql;


                        sql.Open();
                        updateAccountDue.ExecuteNonQuery();
                        sql.Close();

                        //Insert new Data
                        try
                        {
                            SqlConnection sql2 = new SqlConnection(PlugInCode.GetConnection.ConnString());
                            SqlCommand updateAccountNEW = new SqlCommand();


                            updateAccountNEW.CommandText = "UPDATE dbo.tblaccount SET LastUpdateDate='" + date + "', tkDuePayed='" + perseNewPay.ToString() + "', LastUpdateTime='" + time + "' WHERE BillNo='" + txtSearchKey.Text.ToString() + "'";

                            updateAccountNEW.CommandType = CommandType.Text;
                            updateAccountNEW.Connection = sql2;
                            

                            sql2.Open();
                            updateAccountNEW.ExecuteNonQuery();
                            sql2.Close();

                        }
                        catch
                        {
                            MessageBox.Show("Data Not Store Check Connection ");
                        }

                        MessageBox.Show("Data updated");
                        reset();
                        //WhoupdateIt();
                    }
                    catch
                    {
                        MessageBox.Show("Data Not Store Check Connection");
                    }
                }
           
             }
            else
            {
                MessageBox.Show("Search Not Found");
            }
        }

      public void reset()
        {
            txtAddress.Text = "";
            txtLastUpdate.Text = "";
            txtName.Text = "";
            TxtNewPay.Text = "";
            txtPerPay.Text = "";
            txtPhoneNo.Text = "";
            txtPreAmount.Text = "";
            txtPreDue.Text = "";
            txtPrvSft.Text = "";
            txtSearchKey.Text = "";
            txtTodayDate.Text = "";
            ShowBuyData.DataSource = null;
            ShowBuyData.Rows.Clear();
        }

        private void GoBack_EditMenu(object sender, EventArgs e)
        {
            Forms.frmEdit edit = new frmEdit();
            this.Hide();
            edit.Show();
        }
    }
}
