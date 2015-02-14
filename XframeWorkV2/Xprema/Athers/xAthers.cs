using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Xprema.Athers
{
  public   class xAthers
    {

        //كود معرفة عدد الثواني التي مرت على تشغيل الجهاز Get Time by Seconds from PC Start

        public static int GetSecondsComputerStart()
        {
            int SecondsFromStart = Environment.TickCount / 1000;
            return SecondsFromStart;
        }

        //========================================================================

        // كود معرفة دقة الشاشة Get Screen Resolution
        public static string GetScreenResolution()
        {
            string ScrRes = Screen.PrimaryScreen.Bounds.Width + "X" + Screen.PrimaryScreen.Bounds.Height;
            return ScrRes;
        }

        //===============================================================
        public static List<string> GetAllPrinters()
        {
            List<string> Prnt = new List<string>();
            Prnt.Clear();

            for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                Prnt.Add(PrinterSettings.InstalledPrinters[i]);

            }
            return Prnt;
        }
    }
}
