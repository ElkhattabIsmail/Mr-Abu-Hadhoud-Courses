using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Global_Classes;

namespace BusinessLib
{
    public class clsBusinessGlobalClasses
    {
        private static StringBuilder _sbGlobal = new StringBuilder();

        static clsBusinessGlobalClasses()
        {

        }



        public static string GenrateclsDataHelper()
        {
            _GenerateDataHelper();


            return _sbGlobal.ToString();
        }

        private static void _GenerateDataHelper()
        {
            _GenerateDataHelperClass();
        }

        private static void _GenerateDataHelperClass()
        {
            _sbGlobal.Append($@"{_GetClsDataHelperString().Replace("DVLD_Buisness", $@"{clsGlobal.DatabaseName.Replace(" ","")}_Business")}");
           
        }


        private static string _GetClsDataHelperString()
        {
            return @"using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Buisness
{
    public class clsDataHelper
    {
        public static string ComputeHash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashbytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                return BitConverter.ToString(hashbytes).Replace(""-"", """").ToLower();
            }
        }

        public static string Encrypt(string PlainText, string Key)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(Key);
                aesAlg.IV = new byte[aesAlg.BlockSize / 8];

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (var msEncrypt = new System.IO.MemoryStream())
                {
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    using (var swEncrypt = new System.IO.StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(PlainText);
                    }

                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }

        public static string Decrypt(string cipherText, string Key)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(Key);
                aesAlg.IV = new byte[aesAlg.BlockSize / 8];

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (var msDecrypt = new System.IO.MemoryStream(Convert.FromBase64String(cipherText)))
                using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                using (var srDecrypt = new System.IO.StreamReader(csDecrypt))
                {
                    return srDecrypt.ReadToEnd();
                }
            }
        }
    }
}";
        }
    }
}


