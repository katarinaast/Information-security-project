using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace _17959_Katarina_Stanojkovic_ZI
{
    public class TEA
    {

        public string Hash { get; set; }
        public string EncryptTea(string Data, string Key)
        {
            uint[] formattedKey = FormatKey(Key);

            if (Data.Length % 2 != 0) Data += '\0'; // Make sure array is even in length.
            byte[] dataBytes = System.Text.ASCIIEncoding.ASCII.GetBytes(Data);

            string cipher = string.Empty;
            uint[] tempData = new uint[2];
            for (int i = 0; i < dataBytes.Length; i += 2)
            {
                tempData[0] = dataBytes[i];
                tempData[1] = dataBytes[i + 1];
                code(tempData, formattedKey);
                cipher += ConvertUIntToString(tempData[0]) +
                                  ConvertUIntToString(tempData[1]);
            }

            return cipher;
        }

        public string Decrypt(string Data, string Key)
        {
            uint[] formattedKey = FormatKey(Key);

            int x = 0;
            uint[] tempData = new uint[2];
            byte[] dataBytes = new byte[Data.Length / 8 * 2];
            for (int i = 0; i < Data.Length; i += 8)
            {
                tempData[0] = ConvertStringToUInt(Data.Substring(i, 4));
                tempData[1] = ConvertStringToUInt(Data.Substring(i + 4, 4));
                decode(tempData, formattedKey);
                dataBytes[x++] = (byte)tempData[0];
                dataBytes[x++] = (byte)tempData[1];
            }

            string decipheredString =
                    System.Text.ASCIIEncoding.ASCII.GetString(dataBytes,
                                                              0, dataBytes.Length);

            // Strip the null char if it was added.
            if (decipheredString[decipheredString.Length - 1] == '\0')
                decipheredString = decipheredString.Substring(0,
                                                        decipheredString.Length - 1);
            return decipheredString;
        }


        private void code(uint[] v, uint[] k)
        {
            uint y = v[0];
            uint z = v[1];
            uint sum = 0;
            uint delta = 0x9e3779b9;
            uint n = 32;

            while (n-- > 0)
            {
                y += (z << 4 ^ z >> 5) + z ^ sum + k[sum & 3];
                sum += delta;
                z += (y << 4 ^ y >> 5) + y ^ sum + k[sum >> 11 & 3];
            }

            v[0] = y;
            v[1] = z;
        }


        private void decode(uint[] v, uint[] k)
        {
            uint n = 32;
            uint sum;
            uint y = v[0];
            uint z = v[1];
            uint delta = 0x9e3779b9;

            sum = delta << 5;

            while (n-- > 0)
            {
                z -= (y << 4 ^ y >> 5) + y ^ sum + k[sum >> 11 & 3];
                sum -= delta;
                y -= (z << 4 ^ z >> 5) + z ^ sum + k[sum & 3];
            }

            v[0] = y;
            v[1] = z;
        }

        public uint[] FormatKey(string Key)
        {
            if (Key.Length == 0)
                throw new ArgumentException("Key must be between 1 and 16 characters in length");

            Key = Key.PadRight(16, ' ').Substring(0, 16); // Ensure that the key is 16 chars in length.
            uint[] formattedKey = new uint[4];

            // Get the key into the correct format for TEA usage.
            int j = 0;
            for (int i = 0; i < Key.Length; i += 4)
                formattedKey[j++] = ConvertStringToUInt(Key.Substring(i, 4));

            return formattedKey;
        }

        private string ConvertUIntToString(uint Input)
        {
            System.Text.StringBuilder output = new System.Text.StringBuilder();
            output.Append((char)((Input & 0xFF)));
            output.Append((char)((Input >> 8) & 0xFF));
            output.Append((char)((Input >> 16) & 0xFF));
            output.Append((char)((Input >> 24) & 0xFF));
            return output.ToString();
        }

        private uint ConvertStringToUInt(string Input)
        {
            uint output;
            output = ((uint)Input[0]);
            output += ((uint)Input[1] << 8);
            output += ((uint)Input[2] << 16);
            output += ((uint)Input[3] << 24);
            return output;
        }

        public string EncryptTeaParallel(string Data, string Key, int numThreads)
        {

            object lock_object = new object();
            int numOfBlocks = Data.Length / numThreads;
            string[] blocks = new string[numThreads];

            for (int i = 0; i < numThreads; i++)
            {
                int startIndex = i * numOfBlocks;
                int endIndex = startIndex + numOfBlocks;
                if (i == numThreads - 1)
                {
                    endIndex = Data.Length;
                }
                blocks[i] = Data.Substring(startIndex, endIndex - startIndex);
            }

            var result = new List<string>();

            Parallel.ForEach(blocks, new ParallelOptions { MaxDegreeOfParallelism = numThreads }, block =>
            {

                string ciphertext = EncryptTea(block, Key);

                lock (lock_object)
                {
                    result.Add(string.Join("", ciphertext));
                }

            });

            return String.Join("", result.ToArray());
        }

        public string DecryptTeaParallel(string Data, string Key, int numThreads)
        {

            object lock_object = new object();
            int numOfBlocks = Data.Length / numThreads;
            string[] blocks = new string[numThreads];

            for (int i = 0; i < numThreads; i++)
            {
                int startIndex = i * numOfBlocks;
                int endIndex = startIndex + numOfBlocks;
                if (i == numThreads - 1)
                {
                    endIndex = Data.Length;
                }
                blocks[i] = Data.Substring(startIndex, endIndex - startIndex);
            }

            var result = new List<string>();

            Parallel.ForEach(blocks, new ParallelOptions { MaxDegreeOfParallelism = numThreads }, block =>
            {

                string ciphertext = Decrypt(block, Key);

                lock (lock_object)
                {
                    result.Add(string.Join("", ciphertext));
                }

            });

            return String.Join("", result.ToArray());
        }
    }
}
