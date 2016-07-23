using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using RBSoft.Plugin;
using System.Data.SqlClient;

using System.Data;
//Git using 
//2nd cmt

namespace RBSoft.DataEntry
{
    /// <summary>
    /// Interaction logic for DataEnrty.xaml
    /// </summary>
    public partial class DataEntry : Window
    {

        //SqlConnection sql = new SqlConnection("user id=sa;" +
        //                                "password=Rb?Admin;server=localhost;" +
        //                                "Trusted_Connection=yes;" +
        //                                "database=RBDatabase;");

        SqlConnection sql = new SqlConnection(PlugInCode.GetConnection.ConnString());


        string SYSID = "Null";
        string BillID = "Null";
        //string TodayDay = DateTime.Now.Day.ToString();
        //string Todaymonth = DateTime.Now.Month.ToString();
        public static string getSysID()
        { 
            string sysID = "SYSID-" + PlugInCode.GetUniqueKey(3) + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString()+ DateTime.Now.Second.ToString();
            return sysID;
        }
        public static string getBillID()
        {
            string BillNo = "Bill-" + PlugInCode.GetUniqueKey(3) + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Second.ToString();
            return BillNo;
        }


        public DataEntry()
        {
            sql.Close();
            InitializeComponent();
            SYSID = getSysID();
            BillID = getBillID();
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();

            this.Hide();
            main.Show();

        }


        /// <summary>
        /// Person Data Insert 
        /// </summary>
        public void InsertPersonData()
        {
            
            try
            {
                sql.Open();
               
            }
            catch (Exception ex)
            {
               
                MessageBox.Show("Connection Failed " + ex.ToString());
            }
            sql.Close();
            

            //Simple Solution :( 
            // string s = comboBox.Text;
            //int val;
            //string ID = auto();
            //int.TryParse(ID, out val);
            string Name = txtName.Text;
            string PhoneNo = txtContectNumber.Text;
            string Add = txtAddress.Text;
            string ManualBillNo = txtManualBillNO.Text;

            SqlCommand cmd = new SqlCommand();
            //sql.Open();
            // MessageBox.Show("StepDone");
            cmd.CommandText = "insert into dbo.tblPerson(SysID, BillNo, ManualBillNo,Name,PhoneNo,CAddress) values ('" + SYSID + "', '" + BillID + "', '" + ManualBillNo + "', '" + Name + "', '" + PhoneNo + "', '" + Add + "');";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = sql;
            try
            {
                sql.Close();
                // MessageBox.Show("StepDone");
                cmd.Connection = sql;
                sql.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Entry Successfully");
                sql.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.ToString());
                MessageBox.Show("Data Not Entry");
            }


        }

        /// <summary>
        /// Work Oder 1 Inserted
        /// </summary>
        public void InsertWorkOder_0()
        {

            try
            {
                sql.Open();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Connection Failed " + ex.ToString());
            }
            sql.Close();

            string subID ="Print-" + PlugInCode.GetUniqueKey(5) + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString();
            //Simple Solution :( 
            // string s = comboBox.Text;
            //int val;
            //string ID = auto();
            //int.TryParse(ID, out val);
            string vPrintName = this.txtPrintName.Text;
            string vPrintType = this.PrintType.Text;
            string vheight = this.txtHight.Text;
            string vwide = this.txtWide.Text;
            string vsft = this.txtsft.Text;
            string vrate = this.txtRate.Text;
            string vquntity = this.txtquntity.Text;
            string vTotalRate = this.txtTotalRate.Text;
            string vprintStatus = this.PrintStatus.Text;

            SqlCommand cmd = new SqlCommand();
            SqlCommand LinkTblInsert = new SqlCommand();

            sql.Open();
            // MessageBox.Show("StepDone");
            cmd.CommandText = "insert into dbo.tblPrint(SysID, BillNo, SubBillNo ,PrintName,PrintType, PrintLength, PrintWide, Rate, SFT, TotalRate, Quantity, PrintStatus) values ('" + SYSID + "', '" + BillID + "', '" + subID + "', '" + vPrintName + "', '" + vPrintType + "', '" + vheight + "', '" + vwide + "', '" + vrate + "', '" + vsft + "', '" + vTotalRate + "', '" + vquntity + "', '" + vprintStatus + "');";

            LinkTblInsert.CommandText = "insert into dbo.tbllink(BillNo,SubBillNo) values ('" + BillID + "', '" + subID + "')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sql;

            LinkTblInsert.CommandType = CommandType.Text;
            LinkTblInsert.Connection = sql;
            try
            {
                sql.Close();
                // MessageBox.Show("StepDone");
                cmd.Connection = sql;
                sql.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data 2 Entry Successfully");
                sql.Close();
               

                try
                {
                    sql.Close();
                    // MessageBox.Show("StepDone");
                    LinkTblInsert.Connection = sql;
                    sql.Open();
                    LinkTblInsert.ExecuteNonQuery();
                    MessageBox.Show("Link Data Entry Successfully");
                    sql.Close();
                    
                }
                catch
                {

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.ToString());
                MessageBox.Show("Data Not Entry");
            }


        }



        
        /// <summary>
        /// Insert Button
        /// 2 function incluted there 
        /// 1st it inserted the person table Data 
        /// Then insert the 
        /// </summary>
        /// <param name="Insert"></param>
        /// <param name="e"></param>
        private void entryToDB(object sender, RoutedEventArgs e)
        {
            InsertPersonData();
            InsertWorkOder_0();
            Reset();
        }



        /// <summary>
        /// Reset All the Value from the text box 
        /// </summary>
        public void Reset()
        {
           txtManualBillNO.Text = "";
           txtAddress.Text = "";
           txtContectNumber.Text = "";
           txtName.Text = "";
           txtPrintName.Text = "";
           PrintType.Text = "";
           txtHight.Text = "";
           txtWide.Text = "";
           txtsft.Text = "";
           txtRate.Text = "";
           txtquntity.Text = "";
           txtTotalRate.Text = "";
           PrintStatus.Text = "";
           txtName.Text = "";
           txtContectNumber.Text = "";
           txtAddress.Text = "";
           txtManualBillNO.Text = "";
        }



        /// <summary>
        /// Auto Calculation Based on Two textbox value 
        /// </summary>
        private void txtsft_TextChanged(object sender, TextChangedEventArgs e)
        {
            string hight = txtHight.Text;
            string wide = txtWide.Text;
            int valOfHight,valOfWide,sft;

            int.TryParse(hight, out valOfHight);
            int.TryParse(wide, out valOfWide);
            sft = valOfWide * valOfHight;
            txtsft.Text = sft.ToString();

        }
        

        private void Preview_Date_Click(object sender, RoutedEventArgs e)
        {
            ShowPrintName.Text = txtPrintName.Text.ToString();
            ShowPrintStatus.Text = PrintStatus.Text.ToString();
            ShowSFT.Text = txtsft.Text.ToString();
            ShowRate.Text = txtRate.Text.ToString();
            ShowQuan.Text = txtquntity.Text.ToString();
            ShowPrintType.Text = PrintType.Text.ToString();
            ShowRate.Text = txtTotalRate.Text.ToString();

        }
    }
}
