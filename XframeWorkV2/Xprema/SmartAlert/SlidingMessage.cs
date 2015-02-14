using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Xprema.SmartAlert
{
   public  class SlidingMessage
    {

        #region " ^^^  Controls "
        int x, y, z, w;

        Form PopFrm = new Form();

        Timer Tmr1 = new Timer(); Timer Tmr2 = new Timer();
        Timer Tmr3 = new Timer(); Timer Tmr4 = new Timer();
        Timer TimerWaiting = new Timer();

        ProgressBar p = new ProgressBar();

        Label MsgHolderLab = new Label();

        #endregion

        #region "  ^^^ Create Form ^^^           "
        void CreatePopFrm()
        {


            PopFrm.Size = new Size(388, 134);

            ////============================
            PopFrm.BackColor = Color.BurlyWood;
            PopFrm.BackgroundImageLayout = ImageLayout.Stretch;
            MsgHolderLab.ImageAlign = ContentAlignment.TopCenter;
            MsgHolderLab.Image = Xprema.Properties.Resources.Info;
            MsgHolderLab.BackColor = Color.Transparent;
            MsgHolderLab.AutoSize = false;
            MsgHolderLab.Dock = DockStyle.Fill; ;
            MsgHolderLab.TextAlign = ContentAlignment.MiddleCenter;
            MsgHolderLab.ForeColor = Color.White;
            MsgHolderLab.Font = new Font("Times New Roman", 12, FontStyle.Bold);


            PopFrm.Controls.Add(MsgHolderLab);


        }
        #endregion

        #region "   ^^^ Timers Events       "
        private void ActivatePopUpTimers()
        {
            p.Minimum = 0; p.Maximum = 400;

            Tmr1.Enabled = true;
            this.Tmr1.Tick += Tmr1_Tick;
            this.Tmr2.Tick += Tmr2_Tick;
            this.Tmr3.Tick += Tmr3_Tick;
            this.Tmr4.Tick += Tmr4_Tick;
            TimerWaiting.Interval = 5;
            this.TimerWaiting.Tick += TimerWaiting_Tick;
        }


        #endregion


        #region "   ^^^ Timers      "
        void Tmr1_Tick(object sender, EventArgs e)
        {
            PopFrm.SetBounds(x, y, z, w);
            x = x + 40;
            y = y + 20;
            if (x == 360) { Tmr1.Enabled = false; Tmr2.Enabled = true; }
        }
        void Tmr2_Tick(object sender, EventArgs e)
        {
            PopFrm.SetBounds(x, y, z, w);
            z = z + 20; w = w + 20;
            if (z == 300) { Tmr2.Enabled = false; TimerWaiting.Enabled = true; }
        }

        void TimerWaiting_Tick(object sender, EventArgs e)
        {
            p.Value++;
            PopFrm.Cursor = Cursors.WaitCursor;
            if (p.Value == p.Maximum)
            {
                p.Value = 0;
                TimerWaiting.Enabled = false; Tmr3.Enabled = true; PopFrm.Cursor = Cursors.Default;
            }
        }


        void Tmr3_Tick(object sender, EventArgs e)
        {
            PopFrm.SetBounds(x, y, z, w);

            z = z - 20; w = w - 20;
            if (z == 0) { Tmr3.Enabled = false; Tmr4.Enabled = true; }
        }

        void Tmr4_Tick(object sender, EventArgs e)
        {
            PopFrm.SetBounds(x, y, z, w);
            x = x - 40;
            y = y - 20;

            if (x == 0) { Tmr4.Enabled = false; PopFrm.Hide(); }


        }

        #endregion

        #region "   ^^^ Create Message     "
        public void PopUp(string Title, string Msg, string footer)
        {
            CreatePopFrm();
            ActivatePopUpTimers();

            MsgHolderLab.ForeColor = Color.White;
            PopFrm.Text = Title;
            PopFrm.ControlBox = false;
            MsgHolderLab.Text = Msg + System.Environment.NewLine
                + "______________________________" +
                System.Environment.NewLine + footer;
            PopFrm.Visible = true;
            PopFrm.Show();

        }
        #endregion
    }
}
