using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows;
using System.Data;
using System.Security.Cryptography;
using IniParser;
using IniParser.Model;

namespace RBSoft.Plugin
{

    /// <summary>
    /// Connection Information And the connection details return to the connection Call
    /// </summary>
    /// <returns></returns>
    


    public partial class PlugInCode
    {


        #region Login person Rolo/Work as
        public class EmployeeRole
        {
           
             


        }
        #endregion



        #region Create Connection To database 
        public class GetConnection
        {


            //public static string SrvName = @"localhost"; //Your SQL Server Name
            public static string DbName = @"RBBD";//Your Database Name
           // public static string UsrName = "sa";//Your SQL Server User Name
            //public static string Pasword = "01746H3llow?arn";//Your SQL Server Password
            private static string SrvName;
            //private static string DbName;
            private static string UsrName;
            private static string Pasword;


            /// <summary>
            /// Public static method to access connection string throw out the project 
            /// </summary>
            /// <returns>return database connection string</returns>
            public static void GetConnectionString()
            {
                FileIniDataParser fileIniData = new FileIniDataParser();
                fileIniData.Parser.Configuration.CommentString = "#";
                IniData parsedData = fileIniData.ReadFile("Connection.ini");
                SrvName = parsedData["GeneralConnectionConfiguration"]["Server"];
               // DbName = parsedData["GeneralConnectionConfiguration"]["Database"].ToString();  ///Cant connected to the DB ... Problem not solve 
                UsrName = parsedData["GeneralConnectionConfiguration"]["UserName"];
                Pasword = parsedData["GeneralConnectionConfiguration"]["password"];

                //return "Data Source=" + SrvName + "; initial catalog=" + DbName + "; user id="
                //+ UsrName + "; password=" + Pasword + ";Trusted_Connection=yes;";//Build Connection String and Return
            }
            public static string ConnString()
            {
                return "Data Source=" + SrvName + "; initial catalog=" + DbName + "; user id="
               + UsrName + "; password=" + Pasword + ";Trusted_Connection=yes;";//Build Connection String and Return
            }

         }
        #endregion
        
        #region program Navigate 
        // All windows close program 
        public static void CloseAllWindow()
        {
            MainWindow main = new MainWindow();
            DataEntry.DataEntry de = new DataEntry.DataEntry();
            Forms.frmWorkOder WorkOder = new Forms.frmWorkOder();

            WorkOder.Close();
            main.Close();
            de.Close();
            Application.Current.Shutdown(110);
        }
        #endregion


        #region Generate uniqe ID

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

        #endregion

      
         public class Calculation
        {
            public static string multi(string val_1 , string val_2)
            {
                string hight = val_1;
                string wide = val_2;
                int valOfHight, valOfWide, sft;

                int.TryParse(hight, out valOfHight);
                int.TryParse(wide, out valOfWide);
                sft = valOfWide * valOfHight;
                return sft.ToString();
               // txtsft.Text = sft.ToString();
            }
        }
          
    }



}
    
