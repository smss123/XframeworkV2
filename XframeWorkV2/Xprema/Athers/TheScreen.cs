using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Xprema.Athers
{
   public  class TheScreen
    {
        // كود معرفة دقة الشاشة Get Screen Resolution
        public static string GetScreenResolution()
        {
            string ScrRes = Screen.PrimaryScreen.Bounds.Width + "X" + Screen.PrimaryScreen.Bounds.Height;
            return ScrRes;
        }
    }
}
