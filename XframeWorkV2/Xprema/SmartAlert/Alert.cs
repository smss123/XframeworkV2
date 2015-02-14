using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Xprema.SmartAlert
{
   public class Alert
    {
        //===========================================================
        //  { Abu Ehab _  May 2014 }   
        // ^^^ مخــــــطط في المستقبل أضــــافة صـوت لكل رساله
        //===========================================================

        #region " Controls "

        Form Frm = new Form();
        Timer timer1 = new Timer();
        Label ImageLab = new Label();
        Label MsgHolderLab = new Label();
        Panel BackPanel = new Panel();
        #endregion

        #region " Create Controls "
        private void CreateMsgFrm()
        {
            // Form
            Frm.FormBorderStyle = FormBorderStyle.None;
            Frm.StartPosition = FormStartPosition.CenterScreen;
            Frm.BackgroundImageLayout = ImageLayout.Stretch;
            Frm.Size = new Size(468, 60);
            Frm.TopMost = true;
            //=======================================

            // ImageLab
            ImageLab.AutoSize = false;
            ImageLab.Dock = DockStyle.Right;
            ImageLab.BackColor = Color.Transparent;
            ImageLab.ImageAlign = ContentAlignment.MiddleCenter;
            ImageLab.Size = new Size(59, 60);
            ImageLab.BorderStyle = BorderStyle.None;
            Frm.Controls.Add(ImageLab);
            //============================
            // MsgHolderLab
            MsgHolderLab.Size = new Size(330, 60);
            MsgHolderLab.BackColor = Color.Transparent;
            MsgHolderLab.Anchor = AnchorStyles.Right;
            MsgHolderLab.TextAlign = ContentAlignment.MiddleRight;
            MsgHolderLab.ForeColor = Color.White;
            MsgHolderLab.Font = new Font("Times New Roman", 12, FontStyle.Bold);

            Frm.Controls.Add(MsgHolderLab);




        }
        #endregion

        #region "   Timer      "
        private void ActivateTimer()
        {
            timer1.Interval = 3000;
            timer1.Enabled = true;
            this.timer1.Tick += timer1_Tick;

        }
        void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            Frm.Cursor = Cursors.Default;
            Frm.Hide();
        }
        #endregion

        #region "  ^^^ Messages ^^^     "
        public void Info(string Msg)
        {

            CreateMsgFrm();
            ActivateTimer();
            Frm.Cursor = Cursors.WaitCursor;
            ImageLab.Image = Properties.Resources.Info;

            Frm.BackgroundImage = Properties.Resources.BOkey;
            MsgHolderLab.Text = Msg;
            Frm.Show();

        }

        public  void Error(string Msg)
        {
            CreateMsgFrm();
            ActivateTimer();
            Frm.Cursor = Cursors.WaitCursor;
            ImageLab.Image = Properties.Resources.error5;

            Frm.BackgroundImage = Properties.Resources.BError;

            MsgHolderLab.Text = Msg;
            Frm.Show();
        }

        public void Warning(string Msg)
        {
            CreateMsgFrm();
            ActivateTimer();
            Frm.Cursor = Cursors.WaitCursor;
            ImageLab.Image = Properties.Resources.Warning;
            Frm.BackgroundImage = Properties.Resources.BWarnnig;
            MsgHolderLab.Text = Msg;
            Frm.Show();

        }


        public void Attention(string Title, string Msg)
        {
            CreateMsgFrm();


            ImageLab.TextAlign = ContentAlignment.TopCenter;
            Frm.Cursor = Cursors.WaitCursor;
            ImageLab.Image = Properties.Resources.Info2;

            Frm.BackgroundImage = Properties.Resources.BAlaert;
            MsgHolderLab.ForeColor = Color.White;
            MsgHolderLab.Text = "^^ " + Title + " ^^" + System.Environment.NewLine + Msg;
            ActivateTimer();
            Frm.Show();


        }
        #endregion

        #region "  ^^^ About     "
        public void About()
        {

            CreateMsgFrm();
            ActivateTimer();
            Frm.Cursor = Cursors.WaitCursor;
            ImageLab.Image = Properties.Resources.Info;
            Frm.BackgroundImage = Properties.Resources.BOkey;
            MsgHolderLab.TextAlign = ContentAlignment.MiddleLeft;
            MsgHolderLab.ForeColor = Color.White;
            MsgHolderLab.Text = "Made By : Abu Ehab" +
                System.Environment.NewLine + "Palestinain Police Officer" +
                System.Environment.NewLine + " Xprema Software Systems Company @ 2014";
            Frm.Show();
        }
        #endregion 

    }
}
