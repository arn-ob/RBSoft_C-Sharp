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
    public partial class frmEdit_frmEditClientData : Form
    {
        public frmEdit_frmEditClientData()
        {
            InitializeComponent();
            editGroup.Hide();
            
        }

        private void btn_Search_Data_for_edit(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sql = new SqlConnection(PlugInCode.GetConnection.ConnString());
                sql.Close();
                DataTable dt = new DataTable();
                sql.Open();
                SqlDataReader myReaderw = null;


                SqlCommand myCommand = new SqlCommand("select * from dbo.tblPerson where tblPerson.PersonPhnNo ='" + txtSearchKey.Text.ToString() + "'", sql);

                myReaderw = myCommand.ExecuteReader();

                while (myReaderw.Read())
                {

                    string val1 = myReaderw["PersonName"].ToString();
                    string val2 = myReaderw["PersonPhnNo"].ToString();
                    string val3 = myReaderw["PersonAddress"].ToString();
                    string val4 = myReaderw["Details"].ToString();
                    txtName.Text = val1;
                    txtPhoneNo.Text = val2;
                    txtAddress.Text = val3;
                    txtDetails.Text = val4;
                    editGroup.Show();
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
                string sqlque = "select tblPrintDetails.BillNo,tblPrintDetails.SubBillNo,tblPrintDetails.MediaType,tblPrintDetails.Sft, tblPrintDetails.Qunty, tblPrintDetails.PrintStatus from tblPerson,tblPrintDetails where tblPerson.BillNo=tblPrintDetails.BillNo and tblPerson.PersonPhnNo= '01746110246'";

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

        private void btn_UpDdat_data(object sender, EventArgs e)
        {
            string name, phn, add, details;

            name = txtName.Text.ToString();
            phn = txtSearchKey.Text.ToString();
            add = txtAddress.Text.ToString();
            details = txtDetails.Text.ToString();

            try
            {
                SqlConnection sql = new SqlConnection(PlugInCode.GetConnection.ConnString());
                SqlCommand updateClient = new SqlCommand();


                updateClient.CommandText = "UPDATE dbo.tblPerson  SET PersonName='" + name + "', PersonAddress='" + add + "', Details='" + details + "' WHERE PersonPhnNo = '" + phn + "'";

                updateClient.CommandType = CommandType.Text;
                updateClient.Connection = sql;

                
                sql.Open();
                updateClient.ExecuteNonQuery();
                sql.Close();
                MessageBox.Show("Data updated");
                //WhoupdateIt();
            }
            catch
            {
                MessageBox.Show("Data Not Store Check Connection");
            }
           
        }

        private void btnGo_back_editMenu(object sender, EventArgs e)
        {
            frmEdit mainC = new frmEdit();
            this.Hide();
            mainC.Show();

            //Temp Code It must be remove 
            this.Close();
        }
    }
}
