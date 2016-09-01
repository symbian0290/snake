using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace WindowsFormsApplication1
{
    class OpenShutOrReset
    {
        public OpenShutOrReset(string ResetORShutdown, int HouToSleep, int MinToSleep )
        {
            int a = (HouToSleep * 3600) + (MinToSleep * 60);
            if (ResetORShutdown == "reset")
            {
                Process.Start("shutdown.exe", "-a");
                Process.Start("shutdown.exe","-r -t"+" "+ a);
            } else if(ResetORShutdown == "shutdown")
            {
                Process.Start("shutdown.exe", "-a");
                Process.Start("shutdown.exe", "-s -t" + " " + a);
            }
            
        }
    }
}
