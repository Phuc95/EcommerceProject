using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Text;

namespace EcommerceProject.Models
{
    public class EncryptData
    {
        public string EncryptPassword(string plainPassword) {
            StringBuilder sb = new StringBuilder();
            SHA256 sha = SHA256Managed.Create();
            byte[] dataBytes = Encoding.UTF8.GetBytes(plainPassword);
            byte[] result = sha.ComputeHash(dataBytes);
            foreach (byte item in result) {
                sb.Append(item.ToString("x2"));
            }
            string encryptedPassword = sb.ToString();
            return encryptedPassword;
        }
    }
}