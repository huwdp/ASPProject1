using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WCFService
{
    static class Config
    {
        //public static Database context = new Database();
        
        public static Database context
        {
            get
            {
                return new Database();
            }
        }

        public static int passwordOffset = 2;
        public static string extraText = "eCommerce";

        public static string GenerateSalt()
        {
            Random random = new Random();
            char[] salt = new char[2];
            salt[0] = (char)random.Next(48, 122);
            salt[1] = (char)random.Next(48, 122);
            string result = new String(salt);
            return result;
        }

        public static string GenerateHash(string input)
        {
            input = String.Concat(extraText, input);

            byte[] data = Encoding.ASCII.GetBytes(input);
            SHA512 shaM = new SHA512Managed();
            byte[] hash = shaM.ComputeHash(data);

            StringBuilder output = new StringBuilder();
            foreach (var letter in hash)
                output.Append(letter.ToString("X2"));

            return output.ToString();
        }

        public static string GeneratePassword(string input)
        {
            string salt = GenerateSalt();
            string hash = GenerateHash(input);
            string result = string.Concat(salt, hash);
            return result;
        }

        public static string RemoveSalt(string input)
        {
            // Remove salt
            string result = input.Substring(passwordOffset);
            return result;
        }

        public static int PasswordOffet
        {
            get { return passwordOffset; }
        }

    }
}
