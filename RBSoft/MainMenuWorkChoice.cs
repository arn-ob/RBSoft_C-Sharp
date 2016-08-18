using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RBSoft.Plugin;
using System.Data.SqlClient;

namespace RBSoft
{
    public partial class MainMenuWorkChoice : Form
    {
        public static string role;
        public static string val1;


        public MainMenuWorkChoice()
        { 
            InitializeComponent();
            ShowRole();
            IAMa.Text = val1.ToString();
            //Code not Ready
            //AccessRole();


        }

        
        /// <summary>
        /// Cant show access role to label fix it ... :) 
        /// </summary>
        public void AccessRole()
        {
            MainWindow mainWin = new MainWindow();
            MessageBox.Show(mainWin.EmpRole.ToString());
        }


        private void btnWorkOder(object sender, EventArgs e)
        {
            Forms.frmWorkOder workoder = new Forms.frmWorkOder();
            this.Hide();
            workoder.Show();
        }

        private void btnSearch(object sender, EventArgs e)
        {
            Forms.frmSearchData workoder = new Forms.frmSearchData();
            this.Hide();
            workoder.Show();
        }

        private void btn_Account(object sender, EventArgs e)
        {
            Forms.frmAccount account = new Forms.frmAccount();
            this.Hide();
            account.Show();
            this.Close();
            
        }

        
        private void btnlogOut(object sender, EventArgs e)
        {
            /// Notice .................................................
            // Sql script to store log out time to store datebase <<<<<<<<<<<<<< Give it 

            MainWindow loginMenu = new MainWindow();
            this.Hide();
            loginMenu.Show();
            this.Close();
           

        }
        // Test data 
        public static void ShowRole()
        {
            string r = MainWindow.role.ToString();
            
            SqlConnection sql = new SqlConnection(PlugInCode.GetConnection.ConnString());
            sql.Close();
            DataTable dt = new DataTable();
            sql.Open();
            SqlDataReader myReaderw = null;

            SqlCommand myCommand = new SqlCommand("select * from dbo.tblEmployee where tblEmployee.EmpUserName ='" + r + "'", sql);

             myReaderw = myCommand.ExecuteReader();



            while (myReaderw.Read())
            {

               val1 = myReaderw["EmpUserName"].ToString();
                //string val2 = myReaderw["PersonPhnNo"].ToString();
                //string val3 = myReaderw["PersonAddress"].ToString();
                
            }
        }
        
    }
}
