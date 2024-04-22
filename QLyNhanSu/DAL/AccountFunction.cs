using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace QLyNhanSu.DAL
{
    public static class AccountFunction
    {
        public static string CalculateMD5Hash (string input)
        {
            MD5 mD5 = MD5.Create ();
            byte[] inputBytes = Encoding.UTF8.GetBytes (input);
            byte[] hash = mD5.ComputeHash (inputBytes);

            StringBuilder sb = new StringBuilder ();
            for(int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString ();
        }
    }
}
