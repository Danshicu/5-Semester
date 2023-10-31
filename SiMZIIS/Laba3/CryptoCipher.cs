using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography;

namespace Laba3
{
    public static class CryptoCipher
    {
        private static string strIV = "abcdefghijklmnmo"; //The initialization vector.
        private static string strKey = "abcdefghijklmnmoabcdefghijklmnmo"; //The key
        public static Image GetImage(string fileName)
        {
            Image img;
            using var ms = new FileStream(fileName, FileMode.Open);
            img = Image.FromStream(ms);

            return img;
            
        }
        
        public static void MakeEncryption(string inputFile, CipherMode mode, byte[] key, byte[] iv)
        {
            AesCryptoServiceProvider aesProvider = new AesCryptoServiceProvider();
	
            aesProvider.BlockSize = 128;
            aesProvider.KeySize = 192;
            aesProvider.Key = System.Text.Encoding.ASCII.GetBytes(strKey);
            aesProvider.IV = System.Text.Encoding.ASCII.GetBytes(strIV);
            aesProvider.Padding = PaddingMode.ISO10126;
            aesProvider.Mode = mode;
            //Read
            FileStream fileStream = new FileStream(inputFile, FileMode.Open, FileAccess.Read);
            MemoryStream ms = new MemoryStream();
            fileStream.CopyTo(ms);
            //Store header in byte array (we will used this after encryption)
            var img = ms.ToArray();
            var header = ms.ToArray().Take(54).ToArray();
            //Take rest from stream
            var imageArray = ms.ToArray().Skip(54).ToArray();
            //Create encryptor
            fileStream.Close();
            var enc = aesProvider.CreateEncryptor();
            //Encrypt image
            var encimg = enc.TransformFinalBlock(imageArray, 0, imageArray.Length);
            //Combine header and encrypted image
            var image = Combine(header, encimg);
            //Write encrypted image to disk
            File.WriteAllBytes("outFile.bmp", image);
            aesProvider.Clear();
            
        }

        private static byte[] Combine(byte[] first, byte[] second)
        {
            byte[] ret = new byte[first.Length + second.Length];
            Buffer.BlockCopy(first, 0, ret, 0, first.Length);
            Buffer.BlockCopy(second, 0, ret, first.Length, second.Length);
            return ret;
        }
        
        public static void Decrypt(string inFile, string outFile, CipherMode mode)
        {
            AesCryptoServiceProvider aesProvider = new AesCryptoServiceProvider();
            aesProvider.BlockSize = 128;
            aesProvider.KeySize = 192;
            aesProvider.Padding = PaddingMode.ISO10126;
            aesProvider.Mode = mode;
            aesProvider.Key = System.Text.Encoding.ASCII.GetBytes(strKey);
            aesProvider.IV = System.Text.Encoding.ASCII.GetBytes(strIV);

	
            //Read
            FileStream fileStream = new FileStream(inFile, FileMode.Open, FileAccess.Read);
            MemoryStream ms = new MemoryStream();
            fileStream.CopyTo(ms);
            //Store header in byte array (we will used this after encryption)
            var header = ms.ToArray().Take(54).ToArray();
            //Take rest from stream
            var imageArray = ms.ToArray().Skip(54).ToArray();
            //Create encryptor
            var enc = aesProvider.CreateDecryptor();
            //Encrypt image
            var encimg = enc.TransformFinalBlock(imageArray, 0, imageArray.Length);
            //Combine header and encrypted image
            var image = Combine(header, encimg);
            //Write encrypted image to disk
            File.WriteAllBytes(outFile, image);
        }
    }
}