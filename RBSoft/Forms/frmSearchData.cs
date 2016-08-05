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
    public partial class frmSearchData : Form
    {
        string typeStore;


        /// <summary>
        /// Utilize From 
        /// </summary>
        public frmSearchData()
        {
            InitializeComponent();

            //Hide All the Form
            OnlyBillNoShowGrid.Hide();
            AllDataShowGridView.Hide();
        }



        /// <summary>
        /// Search Button Click 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSearchClick(object sender, EventArgs e)
        {
            OnlyBillNoShowGrid.Hide();
            AllDataShowGridView.Hide();
            selectSearchType();  //........ [1]
        }


        //....................................................

        /// <summary>
        /// Get data to typeStore
        /// </summary>
        public void selectSearchType()
        {
            string comboxDataGet = SearchTypeComboBox.Text;
            typeStore = comboxDataGet;
            MakeChoice();  //...........................[2]
        }

        //.....................................................


        /// <summary>
        /// Check which type of Search Ask
        /// </summary>
        public void MakeChoice()
        {
            if (typeStore == "All Data Search")
            {
                search_And_Show_All_Data(); //................... [3]
            }
            else if (typeStore == "Bill Only")
            {
                search_And_Show_only_BillNo(); //................... [4]
            }
            else
            {
                MessageBox.Show("Search Not Found");
            }
        }

        #region Search Function
        /// <summary>
        /// It Search all Data From Database 
        /// </summary>
        public void search_And_Show_All_Data()
            {
                try
                {
                    SqlConnection sql = new SqlConnection(PlugInCode.GetConnection.ConnString());
                    sql.Open();
                    AllDataShowGridView.Show();

                    SqlDataAdapter adapt = new SqlDataAdapter("select * from tblPerson,tblPrintDetails", sql);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    AllDataShowGridView.DataSource = dt;
                    sql.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }


            /// <summary>
            /// it search all the bill no which is regesterd to the DB
            /// </summary>
            public void search_And_Show_only_BillNo()
            {
                try
                {
                    SqlConnection sql = new SqlConnection(PlugInCode.GetConnection.ConnString());
                    sql.Open();
                    OnlyBillNoShowGrid.Show();

                    SqlDataAdapter adapt = new SqlDataAdapter("select BillNo from tblPerson", sql);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    OnlyBillNoShowGrid.DataSource = dt;
                    sql.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        #endregion


        /// <summary>
        /// Back Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBackClick(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(PlugInCode.GetConnection.ConnString());
            sql.Close();


            this.Hide();
            MainWindow main = new MainWindow();
            main.Show();
            

        }
    }
}
