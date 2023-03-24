using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace _17959_Katarina_Stanojkovic_ZI
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string ReadFromFile(string path);

        [OperationContract]
        void WriteToFile(string path, string text);

        [OperationContract]
        string EncryptDecryptRC4(string input, string key);

        [OperationContract]
        string EncryptTea(string Data, string Key);

        [OperationContract]
        string DecryptTea(string Data, string Key);

        [OperationContract]
        byte[] DecryptCBC(byte[] data, byte[] aesKey, byte[] initVec);

        [OperationContract]
        byte[] EncryptCBC(byte[] data, byte[] aesKey, byte[] initVec);

        [OperationContract]
        byte[] EncryptBMP(string path, byte[] key, byte[] vec);

        [OperationContract]
        byte[] DecryptBMP(string path, byte[] key, byte[] vec);

        

        [OperationContract]
        string EncryptDecryptEnigma(string plaintext, string key, string reflector, string plugboard);

       

        [OperationContract]
         uint CalculateCRC(byte[] buf, int size);

        [OperationContract]
        string EncryptDecryptEnigmaParallel(string plaintext, string key, string reflector, string plugboard, int numThreads, string inputFile, string outputFile);

        [OperationContract]
        string EncryptTeaParallel(string Data, string Key, int numThreads);

        [OperationContract]
        string DecryptTeaParallel(string Data, string Key, int numThreads);

    }


    
}
