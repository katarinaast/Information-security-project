using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace _17959_Katarina_Stanojkovic_ZI
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        private RC4 r = new RC4("ncjdakc");
        private ReadWrite rw = new ReadWrite();
        private TEA tea = new TEA();
        //private AES aes;
        private CBC cbc = new CBC();
        private Enigma enigma = new Enigma();
        private CRC Crc = new CRC();

        public string ReadFromFile(string path)
        {
            return rw.ReadFromFile(path);
        }
        public void WriteToFile(string path, string text)
        {
            rw.WriteToFile(path, text);
        }
        public string EncryptDecryptRC4(string input, string key)
        {
            return r.EncryptDecryptRC4(input, key);
        }

        public string EncryptTea(string Data, string Key)
        {
            return tea.EncryptTea(Data, Key);
        }

        public string DecryptTea(string Data, string Key)
        {
            return tea.Decrypt(Data, Key);
        }

        public byte[] EncryptCBC(byte[] data, byte[] aesKey, byte[] initVec)
        {

            return cbc.EncryptCBC(data, aesKey, initVec);
        }
        public byte[] DecryptCBC(byte[] data, byte[] aesKey, byte[] initVec)
        {

            return cbc.DecryptCBC(data, aesKey, initVec);
        }

        public byte[] EncryptBMP(string path, byte[] key, byte[] vec)
        {
            return cbc.EncryptBMP(path, key, vec);
        }

        public byte[] DecryptBMP(string path, byte[] key, byte[] vec)
        {
            return cbc.DecryptBMP(path, key, vec);
        }

 

        public string EncryptDecryptEnigma(string plaintext, string key, string reflector, string plugboard)
        {
            return enigma.EncryptDecryptEnigma(plaintext, key, reflector, plugboard);
        }

        public uint CalculateCRC(byte[] buf, int size)
        {
            return Crc.CalculateCRC(buf, size);
        }

        public string EncryptDecryptEnigmaParallel(string plaintext, string key, string reflector, string plugboard, int numThreads, string inputFile, string outputFile)
        {
            return enigma.EncryptDecryptEnigmaParallel(plaintext, key, reflector, plugboard, numThreads, inputFile, outputFile);
        }

        public string EncryptTeaParallel(string Data, string Key, int numThreads)
        {
            return tea.EncryptTeaParallel(Data, Key, numThreads);
        }

        public string DecryptTeaParallel(string Data, string Key, int numThreads)
        {
            return tea.DecryptTeaParallel(Data, Key, numThreads);
        }








    }
}
