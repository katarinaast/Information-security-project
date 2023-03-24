using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace _17959_Katarina_Stanojkovic_ZI
{
    public class CBC
    {
        protected byte[] round_key;
        protected byte[] aes_result;
        protected byte[] aes_input;
        protected byte[] result;
        protected byte[] bmp;

        protected int round_counter;
        protected int data_counter;
        protected AES aes;

        public CBC() {
            
        }
        public CBC(byte[] aes_key, byte[] init_vec)
        {
            this.round_key = init_vec;
            this.aes = new AES((128 / 8), aes_key);
            this.data_counter = 0;
        }

        public byte[] EncryptCBC(byte[] data, byte[] aesKey, byte[] initVec)
        {
            byte[] round_key = initVec;
            if(this.aes==null)
                this.aes = new AES((128 / 8), aesKey);
            byte[] result = new byte[data.Length];
            int counter = 0;
            for (int i = 0; i < data.Length / 16; i++)
            {
                byte[] block = get_data_block(data, i);
                byte[] data2 = new byte[block.Length];
                for (int j = 0; j < block.Length; j++)
                {
                    data2[j] = (byte)(round_key[j] ^ block[j]);
                }

                byte[] aes_result = aes.encrypt(data2);
                set_init_vector(ref round_key, aes_result);
                foreach (byte b in aes_result)
                {
                    result[counter++] = (byte)b;
                }

                File.WriteAllBytes("C:\\Users\\Kaca\\Desktop\\primer.bin", result);
            }
            string encryptedString = Encoding.ASCII.GetString(result);

            return result;
        }

        public byte[] DecryptCBC(byte[] data, byte[] aesKey, byte[] initVec)
        {
            byte[] buff = File.ReadAllBytes("C:\\Users\\Kaca\\Desktop\\primer.bin");
            byte[] round_key = initVec;
            if (this.aes == null)
                this.aes = new AES((128 / 8), aesKey);
            byte[] result = new byte[data.Length];
            int counter = 0;
            for (int i = 0; i < buff.Length / 16; i++)
            {

                byte[] cipher_block = get_data_block(buff, i);
                byte[,] aes_result = aes.decrypt(cipher_block);
                byte[] aesRes = new byte[16];
                for (int k = 0; k < 4; k++)
                {
                    for (int l = 0; l < 4; l++)
                    {
                        aesRes[k * 4 + l] = aes_result[k, l];
                    }
                }
                byte[] data2 = new byte[cipher_block.Length];
                for (int j = 0; j < cipher_block.Length; j++)
                {
                    data2[j] = (byte)(round_key[j] ^ aesRes[j]);
                }
                set_init_vector(ref round_key, cipher_block);

                foreach (byte b in data2)
                {
                    result[counter++] = b;
                }
            }

            File.Delete("C:\\Users\\Kaca\\Desktop\\primer.bin");
            string decrypted_string = Encoding.ASCII.GetString(result);
            return result;
        }

        protected byte[] get_data_block(byte[] data, int step)
        {
            byte[] data_chunk = new byte[16];
            int counter = 0;
            for (int i = (step * 16); i < ((step * 16) + 16); i++)
                data_chunk[counter++] = data[i];

            return data_chunk;
        }

        protected void set_init_vector(ref byte[] prev_vec, byte[] aes_res)
        {
            prev_vec = aes_res;
        }

        public byte[] EncryptBMP(string path, byte[] key, byte[] vec)
        {
            byte[] bmpPodaci = File.ReadAllBytes(path);
            byte[] header = bmpPodaci.Take(54).ToArray();
            byte[] podaci = bmpPodaci.Skip(54).ToArray();

            byte[] enkriptovanPodatak = EncryptCBC(podaci, key, vec);
            bmp = enkriptovanPodatak;
          
            byte[] data = new byte[header.Length + bmp.Length];
            Array.Copy(header, data, header.Length);
            Array.Copy(bmp, 0, data, header.Length, bmp.Length);

            return data;
        }

        public byte[] DecryptBMP(string path, byte[]key, byte[] vec)
        {
            byte[] bmpData = File.ReadAllBytes(path);
            byte[] header = bmpData.Take(54).ToArray();

            byte[] dekriptovanPodatak = DecryptCBC(bmpData, key, vec);

            byte[] dekPodaci = new byte[header.Length + dekriptovanPodatak.Length];
            Array.Copy(header, dekPodaci, header.Length);
            Array.Copy(dekriptovanPodatak, 0, dekPodaci, header.Length, dekriptovanPodatak.Length);

            return dekPodaci;
        }


    }
}