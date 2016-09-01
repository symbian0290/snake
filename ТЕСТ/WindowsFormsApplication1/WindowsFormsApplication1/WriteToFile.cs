using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApplication1
{
    class WriteToFile
    {
        public WriteToFile(string text, string nameFile)
        {
            byte[] array = System.Text.Encoding.Default.GetBytes(text);

            // запись в файл
            using (FileStream fstream = new FileStream(@nameFile, FileMode.OpenOrCreate))
            {
                // запись массива байтов в файл
                fstream.Write(array, 0, array.Length);
            }
        }
        public WriteToFile(string ResetORShutdown, int HouToSleep, int MinToSleep)
        {
            int a = (HouToSleep * 3600)+(MinToSleep*60);
            string arrayStringBat = "shutdown " ;
            if (ResetORShutdown == "shutdown")
                {
                    arrayStringBat= arrayStringBat + "/s /t " + a + " & ping localhost -n 22";
                }
            else if(ResetORShutdown == "reset")
                {
                    arrayStringBat = arrayStringBat + "/r /t " + a + " & ping localhost -n 22";
                }

            byte[] arrayStringBatToByte = Encoding.Default.GetBytes(arrayStringBat);

            // запись в файл
            using (FileStream fstream = new FileStream(@ResetORShutdown+".bat", FileMode.OpenOrCreate))
            {
                // запись массива байтов в файл
                fstream.Write(arrayStringBatToByte, 0, arrayStringBatToByte.Length);
                
            }
        }
    }
}
