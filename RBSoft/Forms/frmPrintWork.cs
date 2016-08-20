using RBSoft.Plugin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBSoft.Forms
{
    public partial class frmPrintWork : Form
    {
       
        string date = DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year;
        string time = DateTime.Now.Hour + "." + DateTime.Now.Minute + "." + DateTime.Now.Second;
        public frmPrintWork()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Get Data To DB 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowData(object sender, DataGridViewCellMouseEventArgs e)
        {
            string comboxData;
            try
            {
                DataGridViewRow dr = ShowDataGridView.SelectedRows[0];
                txtBillNO.Text = dr.Cells[0].Value.ToString();
                txtSubBillNO.Text = dr.Cells[1].Value.ToString();
                txtName.Text = dr.Cells[2].Value.ToString();
                txtMediaType.Text = dr.Cells[3].Value.ToString();
                txtMediaHight.Text = dr.Cells[4].Value.ToString();
                txtMediaWide.Text = dr.Cells[5].Value.ToString();
                txtMediaSft.Text = dr.Cells[6].Value.ToString();
                txtMediaFileName.Text = dr.Cells[7].Value.ToString();
                comboxData = dr.Cells[8].Value.ToString();
                StatusComboBx.Text = comboxData;


                try
                {
                     
                    if (dr.Cells[9].Value.ToString() != "")
                    {
                        var data = (Byte[])(dr.Cells[9].Value);
                        var stream = new MemoryStream(data);
                        MediaPicture.Image = Image.FromStream(stream);
                    }
                    else
                    {
                        MessageBox.Show("Picture Not Found");
                    }
                    
                }
                catch
                {
                    MessageBox.Show("Picture Not Found");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void btnRefresh(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sql = new SqlConnection(PlugInCode.GetConnection.ConnString());
                sql.Open();


                SqlDataAdapter adapt = new SqlDataAdapter("select tblPerson.BillNo,tblPrintDetails.SubBillNo,tblPerson.PersonName ,tblPrintDetails.MediaType,tblPrintDetails.Hight,tblPrintDetails.Wide,tblPrintDetails.Sft,tblPrintDetails.Filenames,tblPrintDetails.PrintStatus,tblPrintDetails.PrintImage  from dbo.tblPerson,dbo.tblPrintDetails where tblPerson.BillNo=tblPrintDetails.BillNo", sql);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                ShowDataGridView.DataSource = dt;
                sql.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void btnTodayPrint(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(PlugInCode.GetConnection.ConnString());
            sql.Close();
            sql.Open();


            SqlDataAdapter adapt = new SqlDataAdapter("select tblPerson.BillNo,tblPrintDetails.SubBillNo,tblPerson.PersonName ,tblPrintDetails.MediaType,tblPrintDetails.Hight,tblPrintDetails.Wide,tblPrintDetails.Sft,tblPrintDetails.Filenames,tblPrintDetails.PrintStatus,tblPrintDetails.PrintImage  from dbo.tblPerson,dbo.tblPrintDetails where tblPerson.BillNo=tblPrintDetails.BillNo and tblPrintDetails.PrintDate = '" + date + "'", sql);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            
            if (dt.Rows.Count < 1)
            {
                MessageBox.Show("No Data Found");
            }
            else
            {
                DataTable dtToday = new DataTable();
                adapt.Fill(dtToday);
                ShowDataGridView.DataSource = dtToday;
                sql.Close();
            }
        }

        private void btnPreious(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(PlugInCode.GetConnection.ConnString());
            sql.Close();
            sql.Open();


            SqlDataAdapter adapt = new SqlDataAdapter("select tblPerson.BillNo,tblPrintDetails.SubBillNo,tblPerson.PersonName ,tblPrintDetails.MediaType,tblPrintDetails.Hight,tblPrintDetails.Wide,tblPrintDetails.Sft,tblPrintDetails.Filenames,tblPrintDetails.PrintStatus,tblPrintDetails.PrintImage  from dbo.tblPerson,dbo.tblPrintDetails where tblPerson.BillNo=tblPrintDetails.BillNo and not tblPrintDetails.PrintDate = '" + date + "'", sql);
            DataTable dt = new DataTable();
            adapt.Fill(dt);

            if (dt.Rows.Count < 1)
            {
                MessageBox.Show("No Data Found");
            }
            else
            {
                DataTable dtPrev = new DataTable();
                adapt.Fill(dtPrev);
                ShowDataGridView.DataSource = dtPrev;
                sql.Close();
            }
        }

        private void btnSearchByBill(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(PlugInCode.GetConnection.ConnString());
            sql.Close();
            sql.Open();


            SqlDataAdapter adapt = new SqlDataAdapter("select tblPerson.BillNo,tblPrintDetails.SubBillNo,tblPerson.PersonName ,tblPrintDetails.MediaType,tblPrintDetails.Hight,tblPrintDetails.Wide,tblPrintDetails.Sft,tblPrintDetails.Filenames,tblPrintDetails.PrintStatus,tblPrintDetails.PrintImage  from dbo.tblPerson,dbo.tblPrintDetails where tblPerson.BillNo=tblPrintDetails.BillNo and tblPrintDetails.BillNo = '" + txtBillNO.Text.ToString() + "'", sql);
            DataTable dt = new DataTable();
            adapt.Fill(dt);

            if (dt.Rows.Count < 1)
            {
                MessageBox.Show("No Data Found");
            }
            else
            {
                DataTable dtSearchByBill = new DataTable();
                adapt.Fill(dtSearchByBill);
                ShowDataGridView.DataSource = dtSearchByBill;
                sql.Close();
            }
        }

        private void btnSearchBySubBillNo(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(PlugInCode.GetConnection.ConnString());
            sql.Close();
            sql.Open();


            SqlDataAdapter adapt = new SqlDataAdapter("select tblPerson.BillNo,tblPrintDetails.SubBillNo,tblPerson.PersonName ,tblPrintDetails.MediaType,tblPrintDetails.Hight,tblPrintDetails.Wide,tblPrintDetails.Sft,tblPrintDetails.Filenames,tblPrintDetails.PrintStatus,tblPrintDetails.PrintImage  from dbo.tblPerson,dbo.tblPrintDetails where tblPerson.BillNo=tblPrintDetails.BillNo and tblPrintDetails.SubBillNo = '" + txtSubBillNO.Text.ToString() + "'", sql);
            DataTable dt = new DataTable();
            adapt.Fill(dt);

            if (dt.Rows.Count < 1)
            {
                MessageBox.Show("No Data Found");
            }
            else
            {
                DataTable dtSearchBySubBill = new DataTable();
                adapt.Fill(dtSearchBySubBill);
                ShowDataGridView.DataSource = dtSearchBySubBill;
                sql.Close();
            }
        }

        private void btn_GoBack(object sender, EventArgs e)
        {
            MainMenuWorkChoice mainC = new MainMenuWorkChoice();
            this.Hide();
            mainC.Show();

            //Temp Code It must be remove 
            this.Close();

        }

        private void btn_UpdateRecord(object sender, EventArgs e)
        {

            if (ShowDataGridView.RowCount > 0 && txtBillNO.Text != "")
            {
                string combox = StatusComboBx.Text.ToString();
                SqlConnection sql = new SqlConnection(PlugInCode.GetConnection.ConnString());
                SqlCommand update = new SqlCommand();


                update.CommandText = "UPDATE dbo.tblPrintDetails  SET PrintStatus='" + combox + "' WHERE BillNo = '" + txtBillNO.Text.ToString() + "'  AND SubBillNo = '" + txtSubBillNO.Text.ToString() + "'";
                update.CommandType = CommandType.Text;
                update.Connection = sql;

                sql.Open();
                update.ExecuteNonQuery();
                sql.Close();
                MessageBox.Show("Data Updated");
            }
            else
            {
                MessageBox.Show("No Data Found For Update");
            }
        }
    }
}
