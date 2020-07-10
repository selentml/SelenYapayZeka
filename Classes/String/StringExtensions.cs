using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

using Microsoft.VisualBasic;

namespace SelenYapayZekaGit.Classes.String
{
    public static class StringExtensions
    {
        public static string Capitalize(this string gelen)
        {
            if (string.IsNullOrEmpty(gelen)) return string.Empty;
            if(gelen.Length == 1) return gelen.ToUpper();
            return $"{gelen.Substring(0, 1).ToUpper()}{gelen.Substring(1).ToLower()}";
        }

        public static string CapitalizeAll(this string gelen)
        {
            gelen = Strings.Trim(gelen);
            if(gelen.IndexOf(' ') < 1) return gelen.Capitalize();
            string returner = string.Empty;
            var list = gelen.Split(' ');
            foreach (var s in list)
            {
                returner += $"{Capitalize(s)} ";
                
            }

            return returner;
        }
        
 
        public static string AsTitle(this string gelen)
        {
            return $"{SiteYapilandirma.siteAdi} | {CapitalizeAll(gelen)}";
        }

        public static bool SadeceHarfMi(this string input)
        {
            return Regex.IsMatch(input, @"^[a-zA-Z]+$");
        }

        public static  bool GecerliMailMi(this string email)
        {
            try {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch {
                return false;
            }
        }
        
        public      static string ComputeSha256Hash(this string rawData)  
        {  
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())  
            {  
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));  
  
                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();  
                for (int i = 0; i < bytes.Length; i++)  
                {  
                    builder.Append(bytes[i].ToString("x2"));  
                }  
                return builder.ToString();  
            }  
        }

        

        public static string CuzdanSifreli(this string raw)
        {
            if (string.IsNullOrEmpty(raw)) return string.Empty;
            var returner = string.Empty;
            var counter = 1;
            foreach (var a in raw)
            {
                if (counter %2 == 0)
                {
                    returner += a;
                }
                else
                {
                    returner += 'X';
                }

                counter++;
            }

            return returner;
        }
    }
}