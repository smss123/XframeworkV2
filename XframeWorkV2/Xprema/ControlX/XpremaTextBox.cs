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
        public string HideText
        {
            get
            {
                return hideText;
            }
            set
            {
                hideText = value;
                textBox1.Text = value;
            }

        }
        public XpremaTextBox()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           //------------
            if (hideText == "")
            {

            }
            else
            {
                textBox1.Text = hideText;
            }
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (true)
            {
                
            }
        }
    }
}
