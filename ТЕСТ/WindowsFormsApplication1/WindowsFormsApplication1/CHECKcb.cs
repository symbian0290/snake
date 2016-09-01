using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class CHECKcb
    {
        public CHECKcb(bool Check1, bool Check2, bool Check3, int Hour, int Minutes)
        {
            int Hour = (int)numericUpDown1.Value;
            int Minutes = (int)numericUpDown2.Value;

            if (Check1 == false && Check2 == false && Check3 == false)
            {
                ShowMessage EM = new ShowMessage("Ошибка! Необходимо выбрать действия ПК");
            }else if()
            else if (checkBox1.Checked == true && checkBox2.Checked == true)
            {
                MessageBox.Show("Ошибка! Невозможен выбор нескольких вариантов!");
            }
            else if (checkBox1.Checked == true)
            {

                ShowMessage SM = new ShowMessage("shutdown", Hour, Minutes);
                OpenShutOrReset OSoR = new OpenShutOrReset("shutdown", Hour, Minutes);

            }
            else if (checkBox2.Checked == true)
            {

                ShowMessage ShutPC = new ShowMessage("reset", Hour, Minutes);
                OpenShutOrReset OSoR1 = new OpenShutOrReset("reset", Hour, Minutes);
            }

        }
        
    }
}
