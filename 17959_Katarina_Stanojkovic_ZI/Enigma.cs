using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace _17959_Katarina_Stanojkovic_ZI
{
    class Enigma
    {
        private string key;
        private int[] rotors;
        private string reflector;
        private string plugboard;

        public string EncryptDecryptEnigma(string plaintext, string key, string reflector, string plugboard)
        {
            this.key = key;
            this.reflector = reflector;
            this.plugboard = plugboard;
            rotors = new int[3];

            for (int i = 0; i < 3; i++)
            {
                rotors[i] = key[i] - 'A';
            }

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < plaintext.Length; i++)
            {
                
                int letter = plugboard.IndexOf(plaintext[i]); ;
                if (letter % 2 == 0) letter = plugboard[letter + 1] - 'A';
                else letter = plugboard[letter - 1] - 'A';

                char l1 = (char)(letter + 'A');

                int rotor1 = rotors[0]++;
                int rotor2 = rotors[1];
                int rotor3 = rotors[2];

                if (rotors[0] > 25)
                {
                    rotors[0] = 0;
                    rotors[1]++;
                }

                if (rotors[1] > 25)
                {
                    rotors[1] = 0;
                    rotors[2]++;
                }

                if (rotors[2] > 25)
                {
                    rotors[2] = 0;
                }

                letter = (letter + rotor1) % 26;
                letter = (letter + rotor2) % 26;
                letter = (letter + rotor3) % 26;

                l1 = (char)(letter + 'A');
                int r = reflector.IndexOf((char)(letter + 'A'));
                int reflected = reflector[25 - r] - 'A';

                l1 = (char)(reflected + 'A');

                letter = (reflected + rotor3) % 26;
                letter = (letter + rotor2) % 26;
                letter = (letter + rotor1) % 26;

                l1 = (char)(letter + 'A');

                letter = plugboard.IndexOf((char)(letter + 'A')); ;
                if (letter % 2 == 0) letter = plugboard[letter + 1];
                else letter = plugboard[letter - 1];

                sb.Append((char)(letter));
            }

            return sb.ToString();
        }

        public string EncryptDecryptEnigmaParallel(string plaintext, string key, string reflector, string plugboard, int numThreads, string inputFile, string outputFile)
        {

            object lock_object = new object();
            int numOfBlocks = plaintext.Length / numThreads;
            string[] blocks = new string[numThreads];

            for (int i = 0; i < numThreads; i++)
            {
                int startIndex = i * numOfBlocks;
                int endIndex = startIndex + numOfBlocks;
                if (i == numThreads - 1)
                {
                    endIndex = plaintext.Length;
                }
                blocks[i] = plaintext.Substring(startIndex, endIndex - startIndex);
            }

            var result = new List<string>();

            Parallel.ForEach(blocks, new ParallelOptions { MaxDegreeOfParallelism = numThreads }, block =>
            {

                string ciphertext = EncryptDecryptEnigma(block, key, reflector, plugboard);

                lock (lock_object)
                {
                    result.Add(string.Join("", ciphertext));
                }

            });

            return String.Join("", result.ToArray());

        }


    }

}