using System;
using System.Collections.Generic;
using System.Text;
using Laba1;

PasswordController controller = new PasswordController(4);
controller.AnalyzeCharsDistribution();
controller.AnalyseTimeToTakePassword();



namespace Laba1
{
    public class PasswordController
    {
        
        private int _passwordLength;
        public string? Password { get; private set; }

        public PasswordController(int length)
        {
            _passwordLength = length;
            GeneratePassword();
        }
        
        public void GeneratePassword()
        {
            Password = PasswordGenerator.GeneratePasswordWithLength(_passwordLength);
            Console.WriteLine(Password);
        }

        public void AnalyzeCharsDistribution()
        {
            PasswordAnalizer.AnalyzeCharsDistribution(Password);
        }

        public void AnalyseTimeToTakePassword()
        {
            DateTime startTime = DateTime.Now;
            int attempts = 0;
            string? generatedString = null;
            while (generatedString != Password)
            {
                generatedString = PasswordGenerator.GeneratePasswordWithLength(_passwordLength);
                attempts++;
            }
            Console.WriteLine(DateTime.Now - startTime);
            Console.WriteLine(attempts);
        }
        
        public static class PasswordGenerator
        {
            
            private static string _validSymbols = "АаБбВвГгДдЕеЁёЖжЗзИиЙйКкЛлМмНнОоПпРрСсТтУуФфХхЦцЧчШшЩщЪъЫыЬьЭэЮюЯя0123456789";
            private static Random _rand = new Random();
            private static char GetRandomSymbol => _validSymbols[_rand.Next(_validSymbols.Length)];
            

            public static string? GeneratePasswordWithLength(int length)
            {
                StringBuilder builder = new StringBuilder(length);
                for (int index = 0; index < length; index++)
                {
                    builder.AppendFormat($"{GetRandomSymbol}");
                }
                return builder.ToString();
            }
        }

        public static class PasswordAnalizer
        {
            
            public static void AnalyzeCharsDistribution(string password)
            {
                Dictionary<char, int> chars = new Dictionary<char, int>();

                for (int index = 0; index < password.Length; index++)
                {
                    char currentChar = password[index];
                    if (chars.ContainsKey(currentChar))
                    {
                        chars[currentChar] += 1;
                    }
                    else chars.Add(currentChar, 1);
                }

                foreach (var pair in chars)
                {
                    Console.WriteLine($"\n{pair.Key} : {pair.Value}");
                }
            }
        }
    
    }
}