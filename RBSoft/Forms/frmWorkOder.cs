﻿using RBSoft.Plugin;
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
    public partial class frmWorkOder : Form
    {
        #region Global Variable 

        string sysID = "Null";
        string BillNo = "Null";
        string SubBillNo = "Null";
        string date = DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year;
        string time = DateTime.Now.Hour + "." + DateTime.Now.Minute + "." + DateTime.Now.Second;


        #endregion //End of global Variable list


        #region Frm Setup Control
        // Frm Setup
        public frmWorkOder()
        {
            InitializeComponent();

            //Key get
            BillNo = getBillID();
            sysID = getSysID();
            

            //Show thing To forms
            serialIDLable.Text = BillNo.ToString();
            DateShows.Text = date;

            //Hide Some Button
            ProceedToPrint.Hide();
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
            string sysID = "SYSID-" + PlugInCode.GetUniqueKey(4) + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString();
            return sysID;
        }
        public static string getBillID()
        {
            string BillNo = "Bill-" + PlugInCode.GetUniqueKey(2) + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString();
            return BillNo;
        }

        public static string getSubBillID()
        {
            string BillNo = "SubBill-" + PlugInCode.GetUniqueKey(2) + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Minute.ToString()+ DateTime.Now.Second.ToString();
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
            string val1 = txtHight.Text;
            string val2 = txtWide.Text;
            txtSft.Text =  PlugInCode.Calculation.multi(val1, val2);
            
            //int val1 = 0;
            //int val2 = 0;
            //int.TryParse(txtPrice.Text, out val1);
            //int.TryParse(txtSaleQty.Text, out val2);
            //int I = (val1 * val2);
            //txtTotalAmount.Text = I.ToString();
        }

        private void txtSft_MouseEnter(object sender, EventArgs e)
        {
            string val1 = txtHight.Text;
            string val2 = txtWide.Text;
            txtSft.Text = PlugInCode.Calculation.multi(val1, val2);
        }

        #endregion

        #region ClearEveryThing Button 
        /// <summary>
        /// Here Reset all the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Clear()
        {
            txtName.Text = "";
            txtAddress.Text = "";
            txtMobile.Text = "";
            txtHight.Text = "";
            txtQnt.Text = "";
            txtSft.Text = "";
            txtWide.Text = "";
            listView1.Clear();
            StatusComBox.Text = "";
            MediaComBox.Text = "";
        }
        
        private void ClearEveryThing(object sender, EventArgs e)
        {
            ProceedToPrint.Hide();
            Clear();
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
            ProceedToPrint.Show();
            string printType = MediaComBox.Text;
            string status = StatusComBox.Text;
            SubBillNo = getSubBillID();

            if (listView1.Items.Count == 0)
            {

                ListViewItem lst = new ListViewItem();
                lst.SubItems.Add(BillNo.ToString());
                lst.SubItems.Add(SubBillNo.ToString());
                lst.SubItems.Add(MediaComBox.Text);
                lst.SubItems.Add(txtName.Text);
                lst.SubItems.Add(txtHight.Text);
                lst.SubItems.Add(txtWide.Text);
                lst.SubItems.Add(txtQnt.Text);
                lst.SubItems.Add(txtSft.Text);
                lst.SubItems.Add(txtFileName.Text);
                lst.SubItems.Add(StatusComBox.Text);
                

                listView1.Items.Add(lst);
                return;
            }

            ListViewItem lst1 = new ListViewItem();

            lst1.SubItems.Add(BillNo.ToString());
            lst1.SubItems.Add(SubBillNo.ToString());
            lst1.SubItems.Add(MediaComBox.Text);
            lst1.SubItems.Add(txtName.Text);
            lst1.SubItems.Add(txtHight.Text);
            lst1.SubItems.Add(txtWide.Text);
            lst1.SubItems.Add(txtQnt.Text);
            lst1.SubItems.Add(txtSft.Text);
            lst1.SubItems.Add(txtFileName.Text);
            lst1.SubItems.Add(StatusComBox.Text);

            listView1.Items.Add(lst1);
            return;

        }





        #endregion
        
        #region Clear Print Button 
        /// <summary>
        /// it clear the listView1 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearPrintList(object sender, EventArgs e)
        {
            ProceedToPrint.Hide();
            listView1.Clear();
        }





        #endregion

        #region EnterData To Database 
        /// <summary>
        /// Its use store Procedure to insert data to database 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StoreToDB(object sender, EventArgs e)
        {

            SqlConnection sql = new SqlConnection(PlugInCode.GetConnection.ConnString());

            SqlCommand PersonDataQuery = new SqlCommand("PersonData", sql);
            //SqlCommand PrintDetailsQuery = new SqlCommand("PrintDetailsData", sql);


            //PersonData insert
            PersonDataQuery.CommandType = CommandType.StoredProcedure;
            PersonDataQuery.Parameters.Add("@BillNo", SqlDbType.NVarChar).Value = BillNo;
            PersonDataQuery.Parameters.Add("@PersonName", SqlDbType.NVarChar).Value = txtName.Text;
            PersonDataQuery.Parameters.Add("@PersonAddress", SqlDbType.NVarChar).Value = txtAddress.Text;
            PersonDataQuery.Parameters.Add("@PersonPhnNo", SqlDbType.NVarChar).Value = txtMobile.Text;

            
            //Insert Person Data
            try
            {
                sql.Close();
                // MessageBox.Show("StepDone");
                //cmd.Connection = sql;
                sql.Open();
                PersonDataQuery.ExecuteNonQuery();
                //MessageBox.Show("Data Entry Successfully");
                //Clear();
                sql.Close();
                
                //Insert Print Data
                try
                {
                    for (int i = 0; i <= listView1.Items.Count - 1; i++)
                    {
                        SqlCommand PrintDetailsQuery = new SqlCommand();


                        PrintDetailsQuery.CommandText = "INSERT INTO dbo.tblPrintDetails(BillNo,SubBillNo,MediaType,Hight,Wide,Qunty,Sft,Filenames,PrintStatus,PrintDate,PrintTime) VALUES (@BillNo, @SubBillNo, @MediaType, @Hight, @Wide, @Qunty, @Sft, @Filenames, @PrintStatus, @PrintDate, @PrintTime)";

                        PrintDetailsQuery.CommandType = CommandType.Text;
                        PrintDetailsQuery.Connection = sql;

                        PersonDataQuery.CommandType = CommandType.StoredProcedure;
                        PrintDetailsQuery.Parameters.AddWithValue("BillNo", BillNo);
                        PrintDetailsQuery.Parameters.AddWithValue("SubBillNo", listView1.Items[i].SubItems[2].Text);
                        PrintDetailsQuery.Parameters.AddWithValue("MediaType", listView1.Items[i].SubItems[3].Text);
                        PrintDetailsQuery.Parameters.AddWithValue("Hight", listView1.Items[i].SubItems[5].Text);
                        PrintDetailsQuery.Parameters.AddWithValue("Wide", listView1.Items[i].SubItems[6].Text);
                        PrintDetailsQuery.Parameters.AddWithValue("Qunty", listView1.Items[i].SubItems[7].Text);
                        PrintDetailsQuery.Parameters.AddWithValue("Sft", listView1.Items[i].SubItems[8].Text);
                        PrintDetailsQuery.Parameters.AddWithValue("Filenames", listView1.Items[i].SubItems[9].Text);
                        PrintDetailsQuery.Parameters.AddWithValue("PrintStatus", listView1.Items[i].SubItems[10].Text);
                        PrintDetailsQuery.Parameters.AddWithValue("PrintDate", date);
                        PrintDetailsQuery.Parameters.AddWithValue("PrintTime", time);


                        //PersonDataQuery.CommandType = CommandType.StoredProcedure;
                        //PrintDetailsQuery.Parameters.Add("BillNo", SqlDbType.NVarChar).Value = BillNo;
                        //PrintDetailsQuery.Parameters.Add("SubBillNo", SqlDbType.NVarChar).Value = listView1.Items[i].SubItems[2].Text;
                        //PrintDetailsQuery.Parameters.Add("MediaType", SqlDbType.NVarChar).Value = listView1.Items[i].SubItems[3].Text;
                        //PrintDetailsQuery.Parameters.Add("Hight", SqlDbType.NVarChar).Value = listView1.Items[i].SubItems[5].Text;
                        //PrintDetailsQuery.Parameters.Add("Wide", SqlDbType.NVarChar).Value = listView1.Items[i].SubItems[6].Text;
                        //PrintDetailsQuery.Parameters.Add("Qunty", SqlDbType.NVarChar).Value = listView1.Items[i].SubItems[7].Text;
                        //PrintDetailsQuery.Parameters.Add("Sft", SqlDbType.NVarChar).Value = listView1.Items[i].SubItems[8].Text;
                        //PrintDetailsQuery.Parameters.Add("Filenames", SqlDbType.NVarChar).Value = listView1.Items[i].SubItems[9].Text;
                        //PrintDetailsQuery.Parameters.Add("PrintStatus", SqlDbType.NVarChar).Value = listView1.Items[i].SubItems[10].Text;
                        //PrintDetailsQuery.Parameters.Add("PrintDate", SqlDbType.NVarChar).Value = date;
                        //PrintDetailsQuery.Parameters.Add("PrintTime", SqlDbType.NVarChar).Value = time;



                        sql.Open();
                        PrintDetailsQuery.ExecuteNonQuery();
                        sql.Close();
                        //MessageBox.Show("Done");
                    }
                    
                    MessageBox.Show("Data Entry Successfully");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error", ex.ToString());
                    MessageBox.Show("Print Data Not Entry , Contact With System Admin");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.ToString());
                MessageBox.Show("All Data Not Entry , Contact With System Admin");
            }
        }
        #endregion

        
    }
}
