using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Laba1;


namespace Laba1
{
    public class PasswordController
    {
        private PasswordGenerator generator = new PasswordGenerator(); 
        public string? Password { get; private set; }
        public ulong AttemptsToTakePassword { get; private set; }
        
        public void GeneratePassword(int length, ref Random _rand)
        {
            StringBuilder _builder = new StringBuilder();
            Password = generator.GeneratePasswordWithLength(length, ref _rand, ref _builder);
        }

        public Dictionary<char, int> AnalyzeCharsDistribution()
        {
            return PasswordAnalizer.AnalyzeCharsDistribution(Password);
        }

        public void AnalyseTimeToTakePasswordAsync(Stopwatch stopwatch)
        {
            StringBuilder _builder = new StringBuilder();
            AttemptsToTakePassword = 0;
            Random _rand = new Random();
            string? generatedString = null;
            while (generatedString != Password)
            {
                generatedString = generator.GeneratePasswordWithLength(Password.Length, ref _rand, ref _builder);
                AttemptsToTakePassword++;
            }
            stopwatch.Stop();
        }

        public Stopwatch AnalyseTimeToTakePasswordSync(ref Random _rand)
        {
            StringBuilder _builder = new StringBuilder();
            Stopwatch stopwatch = Stopwatch.StartNew();
            AttemptsToTakePassword = 0;
            string? generatedString = null;
            while (generatedString != Password)
            {
                generatedString = generator.GeneratePasswordWithLength(Password.Length, ref _rand, ref _builder);
                AttemptsToTakePassword++;
            }
            stopwatch.Stop();
            Console.WriteLine(Task.CurrentId);
            return stopwatch;
        }
        
        public class PasswordGenerator
        {
            
            private static string _validSymbols = "АаБбВвГгДдЕеЁёЖжЗзИиЙйКкЛлМмНнОоПпРрСсТтУуФфХхЦцЧчШшЩщЪъЫыЬьЭэЮюЯя0123456789";
            private static char GetRandomSymbol(ref Random _rand) => _validSymbols[_rand.Next(_validSymbols.Length)];

            public string? GeneratePasswordWithLength(int length, ref Random _rand, ref StringBuilder _builder)
            {
                _builder.Clear();
                for (int index = 0; index < length; index++)
                {
                    _builder.AppendFormat(GetRandomSymbol(ref _rand).ToString());
                }
                return _builder.ToString();
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