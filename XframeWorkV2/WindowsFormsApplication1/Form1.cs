using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Xprema.XAlerter;
using Xprema.XExtention;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                XName ph = textBox1.Text;
            }
            catch (Xprema.XpremaException ex)
            {
                MessageBox.Show(ex.UserDescriptionArabic);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Xprema.XAlerter.SettingX cmd = new Xprema.XAlerter.SettingX();
            cmd.CheckEveryTime = 5000;
            cmd.AlertStatus = true;
            cmd.Save();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Xprema.XAlerter.SettingX cmd = new Xprema.XAlerter.SettingX();

            textBox1.Text = cmd.LoaderX().CheckEveryTime.ToString();
            checkBox1.Checked = cmd.LoaderX().AlertStatus;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Xprema.XAlerter.SettingX cmd = new Xprema.XAlerter.SettingX();
            cmd.AlertStatus = checkBox1.Checked;
            cmd.CheckEveryTime = textBox1.Text.ToInt();
            cmd.Save();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            XAlertManager cmd = new XAlertManager();
            cmd.Alerts.Add(new XAlert()
            {
                AlertDate = DateTime.Now.AddMinutes(2),
                AlertCaption = "smss Hi ",
                CreatedDate = DateTime.Now,
                Description = "Description",
                Summary = "Summary"
            });
            cmd.commit();
            cmd.OnChangeStatus += cmd_OnChangeStatus;
            cmd.OnFoundAlert += cmd_OnFoundAlert;
            cmd.BeginCheck();
        }

        void cmd_OnFoundAlert(object Sender, XAlert e)
        {
            MessageBox.Show("Found " + e.AlertCaption);
        }

        void cmd_OnChangeStatus(object sender, string e)
        {
            toolStripStatusLabel1.Text = e;
        }
    }
}
