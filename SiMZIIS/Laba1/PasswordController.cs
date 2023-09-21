using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Laba1;

// PasswordController controller = new PasswordController(4);
// controller.AnalyzeCharsDistribution();
// controller.AnalyseTimeToTakePasswordAsync();



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

        public async Task AnalyseTimeToTakePasswordAsync(Stopwatch stopwatch)
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

        public Stopwatch AnalyseTimeToTakePasswordSync(Stopwatch stopwatch)
        {
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