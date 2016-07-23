using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows;
using System.Data;
using System.Security.Cryptography;

namespace RBSoft.Plugin
{

    /// <summary>
    /// Connection Information And the connection details return to the connection Call
    /// </summary>
    /// <returns></returns>
    


    public partial class PlugInCode
    {

        public class GetConnection
        {


            public static string SrvName = @"localhost"; //Your SQL Server Name
            public static string DbName = @"RBBD";//Your Database Name
            public static string UsrName = "sa";//Your SQL Server User Name
            public static string Pasword = "01746H3llow?arn";//Your SQL Server Password

            /// <summary>
            /// Public static method to access connection string throw out the project 
            /// </summary>
            /// <returns>return database connection string</returns>
            public static string GetConnectionString()
            {
                 return "Data Source=" + SrvName + "; initial catalog=" + DbName + "; user id="
                + UsrName + "; password=" + Pasword + ";Trusted_Connection=yes;";//Build Connection String and Return
            }


         }

    // All windows close program 
    public static void CloseAllWindow()
        {
            MainWindow main = new MainWindow();
            DataEntry.DataEntry de = new DataEntry.DataEntry();
            main.Close();
            de.Show();
            Application.Current.Shutdown(110);
        }

        public static string GetUniqueKey(int maxSize)
        {
            char[] chars = new char[62];
            chars = "123".ToCharArray();
            byte[] data = new byte[1];
            RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
            crypto.GetNonZeroBytes(data);
            data = new byte[maxSize];
            crypto.GetNonZeroBytes(data);
            StringBuilder result = new StringBuilder(maxSize);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            return result.ToString();
        }






    }


    
}
    
