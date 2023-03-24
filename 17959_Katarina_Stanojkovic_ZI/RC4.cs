using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace _17959_Katarina_Stanojkovic_ZI
{
    public class RC4
    {
        private string key;
        public RC4(string key)
        {
            this.key = key;
        }

        public string EncryptDecryptRC4(string input, string key)
        {
            StringBuilder result = new StringBuilder();
            int x, y, j = 0;
            int[] s = new int[256];
            for (int i = 0; i < 256; i++)
                s[i] = i;
            for (int i = 0; i < 256; i++)
            {
                j = (key[i % key.Length] + s[i] + j) % 256;
                x = s[i];
                s[i] = s[j];
                s[j] = x;
            }
            for (int i = 0; i < input.Length; i++)
            {
                y = i % 256;
                j = (s[y] + j) % 256;
                x = s[y];
                s[y] = s[j];
                s[j] = x;
                result.Append((char)(input[i] ^ s[(s[y] + s[j]) % 256]));
            }
            return result.ToString();
        }
    }
}
