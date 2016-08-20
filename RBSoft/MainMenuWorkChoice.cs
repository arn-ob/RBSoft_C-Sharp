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
        public static string EmpUsername;
        
        public static string EmpRole;


        public MainMenuWorkChoice()
        { 
            InitializeComponent();
            ShowRole();
            makeRoleBasedWork();
            lblRole.Text = EmpRole.ToString();
            lblYourName.Text = EmpUsername.ToString();
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
            Forms.frmAccounts account = new Forms.frmAccounts();
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
       

        private void btn_PrintWork(object sender, EventArgs e)
        {
            Forms.frmPrintWork printWork = new Forms.frmPrintWork();
            this.Hide();
            printWork.Show();
            this.Close();
        }

        private void gotoFrmEdit(object sender, EventArgs e)
        {
            Forms.frmEdit frmedit = new Forms.frmEdit();
            this.Hide();
            frmedit.Show();
            this.Close();
        }

        // Test data 
        public static void ShowRole()
        {
            role = MainWindow.role.ToString();

            SqlConnection sql = new SqlConnection(PlugInCode.GetConnection.ConnString());
            sql.Close();
            DataTable dt = new DataTable();
            sql.Open();
            SqlDataReader myReaderw = null;

            SqlCommand myCommand = new SqlCommand("select * from dbo.tblEmployee where tblEmployee.EmpUserName ='" + role + "'", sql);

            myReaderw = myCommand.ExecuteReader();



            while (myReaderw.Read())
            {

                EmpUsername = myReaderw["EmpUserName"].ToString();
                EmpRole = myReaderw["EmpjobTitle"].ToString();
                //string val2 = myReaderw["PersonPhnNo"].ToString();
                //string val3 = myReaderw["PersonAddress"].ToString();

            }
        }

        public void makeRoleBasedWork()
        {
            if(EmpRole == "Developer")
            {
                //MessageBox.Show("Welcome Dev");
            }
            else if (EmpRole == "Admin")
            {
                //MessageBox.Show("Welcome Admin");
            }
            else if (EmpRole == "Designer")
            {
                button1.Show(); // Work Oder

                button2.Hide(); // Search
                button4.Hide(); // Account
                button5.Hide(); // Employee

                button7.Show(); //Edit Data

                button6.Hide(); // Print Work
            }
            else if (EmpRole == "Printer")
            {
                button1.Hide(); // Work Oder

                button2.Hide(); // Search
                button4.Hide(); // Account
                button5.Hide(); // Employee

                button7.Show(); //Edit Data   //Show

                button6.Show(); // Print Work  //Show
            }
            else if (EmpRole == "Account")
            {
                button1.Hide(); // Work Oder

                button2.Hide(); // Search
                button4.Show(); // Account  //Show
                button5.Hide(); // Employee

                button7.Show(); //Edit Data  // Show

                button6.Hide(); // Print Work
            }else
            {
                MessageBox.Show("Who Are U ?");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Forms.frmEmployee empfrom = new Forms.frmEmployee();
            this.Hide();
            empfrom.Show();
        }
    }
}
