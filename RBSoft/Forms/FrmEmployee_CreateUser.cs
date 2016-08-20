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
    public partial class FrmEmployee_CreateUser : Form
    {
        public string check;
        byte[] StoreTempImage;
        string date = DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year;
       string createID = DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year +""+ DateTime.Now.Hour + DateTime.Now.Minute;


        public FrmEmployee_CreateUser()
        {
            InitializeComponent();
            txtShowDate.Text = date.ToString();
        }

        public void CheckDAta()
        {
            if(txtAddress.Text =="" || txtName.Text == "" || txtPassword.Text == "" || txtPhoneNo.Text == "" || txtPictureName.Text == "" || txtUserName.Text == "")
            {
                MessageBox.Show("Check input , Fill All The Data");
                check =  "true";
            }
            else
            {
                check = "false";
            }
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            if (check.ToString() == "false")
            {
                string jobtitle = TitleComboBox.Text.ToString();
                SqlConnection sql = new SqlConnection(PlugInCode.GetConnection.ConnString());
                SqlCommand createUserCmd = new SqlCommand();


                createUserCmd.CommandText = "INSERT INTO dbo.tblEmployee(EmpID,EmpName,EmpjobTitle,EmpAddress,EmpPhnNo,EmpJoinDate,EmpUserName,EmpSoftPass,EmpImage,EmpComment) VALUES (@EmpID, @EmpName, @EmpjobTitle, @EmpAddress, @EmpPhnNo, @EmpJoinDate, @EmpUserName, @EmpSoftPass, @EmpImage, @EmpComment)";

                createUserCmd.CommandType = CommandType.Text;
                createUserCmd.Connection = sql;


                createUserCmd.Parameters.AddWithValue("EmpID", createID );
                createUserCmd.Parameters.AddWithValue("EmpName", txtName.Text.ToString());
                createUserCmd.Parameters.AddWithValue("EmpjobTitle", jobtitle );
                createUserCmd.Parameters.AddWithValue("EmpAddress", txtAddress.Text.ToString());
                createUserCmd.Parameters.AddWithValue("EmpPhnNo", txtPhoneNo.Text.ToString());
                createUserCmd.Parameters.AddWithValue("EmpJoinDate", date);
                createUserCmd.Parameters.AddWithValue("EmpUserName", txtUserName.Text.ToString());
                createUserCmd.Parameters.AddWithValue("EmpSoftPass", txtPassword.Text.ToString());
                createUserCmd.Parameters.AddWithValue("EmpImage", StoreTempImage);
                createUserCmd.Parameters.AddWithValue("EmpComment", txtComment.Text.ToString());
                
                sql.Open();
                createUserCmd.ExecuteNonQuery();
                sql.Close();
                MessageBox.Show("Employee ID : " + createID.ToString());
            }
        }



        private void btnGetImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog fop = new OpenFileDialog();
            fop.InitialDirectory = @"C:\";
            fop.Filter = "[JPG,JPEG]|*.jpg";
            if (fop.ShowDialog() == DialogResult.OK)
            {
                FileStream FS = new FileStream(@fop.FileName, FileMode.Open, FileAccess.Read);
                byte[] img = new byte[FS.Length];
                FS.Read(img, 0, Convert.ToInt32(FS.Length));
                StoreTempImage = img;
                txtPictureName.Text = fop.SafeFileName.ToString();
            }
        }

        private void BtnGoBack_Click(object sender, EventArgs e)
        {
            Forms.frmEmployee frmEmp = new frmEmployee();
            this.Hide();
            frmEmp.Show();
        }
    }
}
