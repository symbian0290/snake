using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class ShowMessage
    {
        public string TextForMass = "qwe";
        MessageBox
        public ShowMessage(string text)
        {
            MessageBox.Show(text);
        }
        
        public ShowMessage(string resetORshutdown, int Hour, int Minutes)
        {
            if(resetORshutdown =="reset")
            {
               MessageBox.Show("Компьютер перезагрузится через: " + Hour + "ч." + Minutes + "мин.");
            }
            else if(resetORshutdown == "shutdown")
            {
                MessageBox.Show("Компьютер выключится через: " + Hour + "ч." + Minutes + "мин.");
            }
            
        }
    }
}
