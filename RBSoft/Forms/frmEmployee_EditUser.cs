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
    public partial class frmEmployee_EditUser : Form
    {
        public frmEmployee_EditUser()
        {
            InitializeComponent();
        }

       //public void SearchMemberByID()
       // {
       //     SqlConnection sql = new SqlConnection(PlugInCode.GetConnection.ConnString());
       //     sql.Close();
       //     sql.Open();
       //     Bill_no_var = billno.Text.ToString();

       //     SqlDataAdapter adapt = new SqlDataAdapter("select * from tblPrintDetails where BillNo='" + Bill_no_var + "'", sql);
       //     DataTable dt = new DataTable();
       //     adapt.Fill(dt);


       //     if (dt.Rows.Count > 0)
       //     {
       //         sql.Close();
       //         GetDataToTextField(Bill_no_var);
               
       //     }
       //     else
       //     {
       //         MessageBox.Show("Bill Not Found");
              
       //     }

        //}
        //public void GetDataToTextField(string value)
        //{


        //    SqlConnection sql = new SqlConnection(PlugInCode.GetConnection.ConnString());
        //    sql.Close();
        //    DataTable dt = new DataTable();
        //    sql.Open();
        //    SqlDataReader myReaderw = null;


        //    SqlCommand myCommand = new SqlCommand("select * from dbo.tblPerson where tblPerson.BillNo ='" + value + "'", sql);

        //    myReaderw = myCommand.ExecuteReader();

        //    while (myReaderw.Read())
        //    {

        //        string val1 = myReaderw["PersonName"].ToString();
        //        string val2 = myReaderw["PersonPhnNo"].ToString();
        //        string val3 = myReaderw["PersonAddress"].ToString();

        //        txtClientName.Text = val1;
        //        txtClientPhnNo.Text = val2;
        //        txtClientAddress.Text = val3;

        //        // Here Never disconnect sql
        //    }

        //    sql.Close();
        //    sql.Open();
        //}


    }
}
