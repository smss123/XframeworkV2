using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Xprema.ControlX
{
    public partial class XpremaTextBox : UserControl
    {
        public TextBox TextBoxSetting 
        {

            get
            {
                return textBox1;
            }
            set
            {
                textBox1 = value;
            }
        
        }
        public bool  AllowNull { get; set; }
        string hideText;
        public string  HideText {
            get
            {
                return hideText;
            } set
              {
              	hideText = value;
              }
        
        }
        public XpremaTextBox()
        {
            InitializeComponent();
        }
    }
}
