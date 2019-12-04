using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace Codeathon.API.Utilities
{
    public static class StringExtension
    {
        public static string Hasing(this string input)
        {
            byte[] data = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sb = new StringBuilder();
            foreach (byte b in data)
                sb.Append(b.ToString("X2"));
            return sb.ToString();
        }

        /// <summary>
        /// Get image from path and convert it into base64 string
        /// </summary>
        /// <param name="path">Image path</param>
        /// <returns>Base64 String</returns>
        public static string ImagePathToBase64(this string path)
        {
            try
            {
                using (System.Drawing.Image image = System.Drawing.Image.FromFile(path))
                {
                    using (MemoryStream m = new MemoryStream())
                    {
                        image.Save(m, image.RawFormat);
                        byte[] imageBytes = m.ToArray();
                        return Convert.ToBase64String(imageBytes);
                    }
                }
            }
            catch
            {
                return "";
            }
        }
        /// <summary>
        /// Recreating image from Base64 String
        /// </summary>
        /// <param name="base64String">Base64 String</param>
        /// <returns>Image</returns>
        public static System.Drawing.Image MakeImage(this string base64String)
        {
            try
            {
                byte[] imageBytes = Convert.FromBase64String(base64String);
                MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
                ms.Write(imageBytes, 0, imageBytes.Length);
                System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
                return image;
            }
            catch
            {
                return new System.Drawing.Bitmap(0,0);
            }
        }
    }
 
}
