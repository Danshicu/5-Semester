using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Laba1;


namespace Laba1
{
    public class PasswordController
    {
        
        public string? Password { get; private set; }
        public ulong AttemptsToTakePassword { get; private set; }
        
        public void GeneratePassword(int length)
        {
            Password = PasswordGenerator.GeneratePasswordWithLength(length);
        }

        public Dictionary<char, int> AnalyzeCharsDistribution()
        {
            return PasswordAnalizer.AnalyzeCharsDistribution(Password);
        }

        public void AnalyseTimeToTakePasswordAsync(Stopwatch stopwatch)
        {
            AttemptsToTakePassword = 0;
            string? generatedString = null;
            while (generatedString != Password)
            {
                generatedString = PasswordGenerator.GeneratePasswordWithLength(Password.Length);
                AttemptsToTakePassword++;
            }
            stopwatch.Stop();
        }

        public Stopwatch AnalyseTimeToTakePasswordSync()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            AttemptsToTakePassword = 0;
            string? generatedString = null;
            while (generatedString != Password)
            {
                generatedString = PasswordGenerator.GeneratePasswordWithLength(Password.Length);
                AttemptsToTakePassword++;
            }
            stopwatch.Stop();
            return stopwatch;
        }
        
        public static class PasswordGenerator
        {
            
            private static string _validSymbols = "АаБбВвГгДдЕеЁёЖжЗзИиЙйКкЛлМмНнОоПпРрСсТтУуФфХхЦцЧчШшЩщЪъЫыЬьЭэЮюЯя0123456789";
            private static Random _rand = new Random();
            private static char GetRandomSymbol => _validSymbols[_rand.Next(_validSymbols.Length)];
            private static StringBuilder builder = new StringBuilder();
            

            public static string? GeneratePasswordWithLength(int length)
            {
                builder.Clear();
                for (int index = 0; index < length; index++)
                {
                    builder.AppendFormat(GetRandomSymbol.ToString());
                }
                return builder.ToString();
            }
        }

        public static class PasswordAnalizer
        {
            
            public static Dictionary<char, int> AnalyzeCharsDistribution(string password)
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
                return chars;
            }
        }
    
    }
}