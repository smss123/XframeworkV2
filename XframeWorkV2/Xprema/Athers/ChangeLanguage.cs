using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Xprema.Athers
{
   public class ChangeLanguage
    {
        public static void SetKeyboardLanguage(string CultureName)
        {
            System.Globalization.CultureInfo MyLang = new System.Globalization.CultureInfo(CultureName);
            InputLanguage InLang = InputLanguage.FromCulture(MyLang);
            InputLanguage.CurrentInputLanguage = InLang;
        }

    }
}
