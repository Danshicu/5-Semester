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
        public static Image GetImage(byte[] bytes)
        {
            Image img;
            using (var ms = new MemoryStream(bytes))
            {
                ms.Position = 0;
                ms.Write(bytes, 0, bytes.Length);
                img = Image.FromStream(ms);
            }

            return img;
            
        }
        
        public static byte[] MakeEncryption(string inputFile, CipherMode mode, byte[] key, byte[] iv)
        {
            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
            aes.BlockSize = 128;
            aes.KeySize = 256;
                aes.Key = key;
                aes.IV = iv;
                aes.Padding = PaddingMode.None;
                aes.Mode = mode;

                FileStream fileStream = new FileStream(inputFile, FileMode.Open, FileAccess.Read);
                MemoryStream ms = new MemoryStream();
                fileStream.CopyTo(ms);

                var header = ms.ToArray().Take(54).ToArray();
                var img = ms.ToArray().Skip(54).ToArray();
                fileStream.Close();
                var encryptor = aes.CreateEncryptor();

                var encryptedImage = encryptor.TransformFinalBlock(img, 0, img.Length);
                var newImage = Combine(header, encryptedImage);

                // using (MemoryStream input = new MemoryStream(imageBytes))
                // using (MemoryStream encrypted = new MemoryStream())
                // using (CryptoStream cryptoStream = new CryptoStream(encrypted, encryptor, CryptoStreamMode.Write))
                // {
                //     input.CopyTo(cryptoStream);
                //     return encrypted.ToArray();
                // }
                File.WriteAllBytes("encryptedFile.bmp", newImage);
                return newImage;
            
        }

        private static byte[] Combine(byte[] first, byte[] second)
        {
            byte[] ret = new byte[first.Length + second.Length];
            Buffer.BlockCopy(first, 0, ret, 0, first.Length);
            Buffer.BlockCopy(second, 0, ret, first.Length, second.Length);
            return ret;
        }
    }
}