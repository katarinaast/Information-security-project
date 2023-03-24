using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace _17959_Katarina_Stanojkovic_ZI
{
    public class ReadWrite
    {
        //private string path;
        private byte[] loadedFile;
        private string text;
        public string ReadFromFile(string path)
        {
            FileStream fileToRead = null;

            try
            {
                fileToRead = new FileStream(path, FileMode.Open);
                int length = (int)fileToRead.Length;
                byte[] byteArray = new byte[length];
                fileToRead.Read(byteArray, 0, length);
                loadedFile = byteArray;
                text= Encoding.ASCII.GetString(loadedFile);

            }
            catch (IOException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                fileToRead.Close();
            }
            return text;
        }

        public void WriteToFile(string path, string text)
        {
            FileStream fileToWrite = null;
            try
            {
                byte[] textToWrite = new byte[text.Length];
                textToWrite = Encoding.UTF8.GetBytes(text);

                fileToWrite = new FileStream(path, FileMode.Create);
                fileToWrite.Write(textToWrite, 0, textToWrite.Length);

            }
            catch (IOException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                fileToWrite.Close();
            }
            
            return;
        }

       
    }
}