using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Xprema.Controllers
{
    public partial class XpremaTextBox : UserControl
    {
        public XpremaTextBox()
        {
            InitializeComponent();
            this.Resize += XpremaTextBox_Resize;
        }

        void XpremaTextBox_Resize(object sender, EventArgs e)
        {
            textBox1.Width = this.Width;
            textBox1.Height = this.Height;
            if (textBox1.Height >= this.Height)
            {
                this.Height = textBox1.Height;
            }
        }

        

            public string  Value
                {
                     get { return textBox1.Text;  }
                     set { textBox1.Text = value; }
                }

        public Control  XTextBox
        {
            get
            {
                return this.textBox1;
            }
            set
            {
                 this.textBox1 = (TextBox)value;
            }
        }

        private void XpremaTextBox_Load(object sender, EventArgs e)
        {

        }
    }

    public partial class XprmeaTextBox
    {
        //Property Here

      
        
        
        
    }
}
