using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Xprema.XAlerter
{
   public class SettingX
    {
       public SettingX()
       {
          //this.LoaderX();
       }
       public SettingX(string str)
       {
           // only Over Loading
       }
       private  const string FileName = "_AlertSetting.xml";

        public  bool  AlertStatus { get; set; }
       /// <summary>
       /// Time Per MiliSconde
       /// </summary>
        public  int CheckEveryTime { get; set; }

       /// <summary>
       /// Save Settings
       /// </summary>
        public  void Save()
        {
            string Dir = Application.StartupPath + "\\AlertManager";
            string fileFullPath = Dir + "\\" + FileName;
            if (!System.IO.Directory.Exists(Dir))
            {
                System.IO.Directory.CreateDirectory(Dir);
            }
            Xml.XmlFileManager cmd = new Xml.XmlFileManager();
            SettingX _setting = new SettingX();
            _setting.AlertStatus = this.AlertStatus;
            _setting.CheckEveryTime = this.CheckEveryTime;
            cmd.FileName = FileName;
            cmd.FilePath = Dir;
            cmd.Commit(_setting);
        }
        public SettingX LoaderX()
        {
            string Dir = Application.StartupPath + "\\AlertManager";
             if (!System.IO.Directory.Exists(Dir))
            {
                System.IO.Directory.CreateDirectory(Dir);
            }
            
            SettingX _setting = new SettingX() ;
            SettingX s = new SettingX("");

            Xml.XmlFileManager cmd = new Xml.XmlFileManager();
            cmd.FileName = FileName;
            cmd.FilePath = Dir;
            _setting = (SettingX)cmd.Load(_setting) ;
            this.AlertStatus = _setting.AlertStatus;
            this.CheckEveryTime = _setting.CheckEveryTime;
            return _setting;
        }
    }
}
