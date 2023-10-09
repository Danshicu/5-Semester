namespace Laba2
{
    public static class SkytaleCrypt
    {
        public static string Encrypt(string text, int diameter)
        {
            var k = text.Length % diameter;
            if (k > 0)
            {
                text += new string(' ', diameter - k);
            }

            var columnCount = text.Length / diameter;
            var result = "";

            for (int i = 0; i < columnCount; i++)
            {
                for (int j = 0; j < diameter; j++)
                {
                    result += text[i + columnCount * j].ToString();
                }
            }

            return result;
        }


        public static string Decrypt(string text, int diameter)
        {
            var columnCount = text.Length / diameter;
            var symbols = new char[text.Length];
            int index = 0;

            for (int i = 0; i < columnCount; i++)
            {
                for (int j = 0; j < diameter; j++)
                {
                    symbols[i + columnCount * j] = text[index];
                    index++;
                }
            }

            return string.Join("", symbols);
        }
    }
    
}