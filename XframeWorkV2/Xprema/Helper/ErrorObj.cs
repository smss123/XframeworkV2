using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xprema.Helper
{
   internal class ErrorObj:XpremaBaseClass
    {
        public int CodeNumber { get; set; }
        public string Description { get; set; }
        public string OtherDescription { get; set; }
        public string  UserMessage { get; set; }
        public string  UserMessageArabic { get; set; }
    }
}
