using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xprema.Xml;
using System.Threading;
using System.Windows.Forms;
namespace Xprema.XAlerter
{
  public  class XAlertManager:XpremaBaseClass
    {
      public override string aboutObjet
      {
          get
          {
              return "Management specializes in the management of alerts and notifications to show in the system";
          }
         
      }
      public delegate void AlertStatusCallBack(object sender, string e);
      public  event AlertStatusCallBack OnChangeStatus;
        private  const string FileName = "_AlertManager.xml";
       private string Dir = Application.StartupPath + "\\AlertManager";
           
      public  delegate void AlertArgCallBack(object Sender, XAlert e);// this Delagte to Help Event
      public  event AlertArgCallBack OnFoundAlert;// Fire On Found New Alert
      private  List<XAlert> _Alerts = new List<XAlert>();//List Of Dircetion
        public  List<XAlert> Alerts
        {
            get { return _Alerts; }
            set { _Alerts = value; }
        }
        public  void commit()
        {
            XmlFileManager cmd = new XmlFileManager();
            if (!System.IO.Directory.Exists(Dir))
            {
                System.IO.Directory.CreateDirectory(Dir);
            }
            cmd.FilePath = Dir;
            cmd.FileName = FileName;
            cmd.Commit(_Alerts);
        }
        public  List<XAlert> Loader()
        {
            List<XAlert> Ls = new List<XAlert>();
            XmlFileManager cmd = new XmlFileManager();
            if (!System.IO.Directory.Exists(Dir))
            {
                System.IO.Directory.CreateDirectory(Dir);
            }
            cmd.FilePath = Dir;
            cmd.FileName = FileName;
            Ls = (List<XAlert>)cmd.Load(Ls);
            return Ls;
        }
        public string  Status { get; set; }
        
        public  void BeginCheck()
        {
            CheckIfActive();
            Thread th = new Thread(() => {

                Checker();
              
            
            
            });
            th.Start();

        }

        private void Checker()
        {
            Xprema.XAlerter.SettingX cmd = new Xprema.XAlerter.SettingX();
            var q = cmd.LoaderX();
            if (q.AlertStatus)
            {

                while (true)
                {
                    var alr = Loader();
                    foreach (var item in alr)
                    {

                        if (item.AlertDate.Year == DateTime.Now.Year &&
                            item.AlertDate.Month == DateTime.Now.Month &&
                            item.AlertDate.Day == DateTime.Now.Day &&
                            item.AlertDate.Hour == DateTime.Now.Hour &&
                            item.AlertDate.Minute == DateTime.Now.Minute
                        )
                        {
                            this.OnFoundAlert(this, item);
                        }


                    }
                    Thread.Sleep(q.CheckEveryTime);
                }
                







            }
        }

        private  void CheckIfActive()
        {
            Thread th = new Thread(() => {

                while (true)
                {
                    Xprema.XAlerter.SettingX cmd = new Xprema.XAlerter.SettingX();
                    var q = cmd.LoaderX();
                    if (q.AlertStatus)
                    {

                        OnChangeStatus(null, "Active");

                    }
                    else
                    {
                        OnChangeStatus(null, "Not Active");
                    }
                    Thread.Sleep(4000);
                }

               
            });
            th.Start();
        }

      

    }
}
