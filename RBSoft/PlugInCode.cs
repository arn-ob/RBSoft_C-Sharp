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
    public partial class PlugInCode
    {
       
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
    
