using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Xprema.Xml
{
  public  class XmlFileManager :XpremaBaseClass
    {
        public string  FileName { get; set; }
        public string  FilePath { get; set; }
        private string fullPath;

        public XmlFileManager()
        {
            ini();
        }

        private void ini()
        {
            fullPath = FilePath + "\\" + FileName;
        }
        public bool Commit(object obj)
        {
            ini();
            bool state = false;
            XmlSerializer writer =
             new XmlSerializer(obj.GetType());
            System.IO.StreamWriter file =
                new System.IO.StreamWriter(fullPath);

            writer.Serialize(file, obj);
            file.Close();


            return state;
        }
        public object Load(object obj)
        {
            object LoadObj;
            var reader = new
         System.Xml.Serialization.XmlSerializer(obj.GetType());

            // Read the XML file.
            System.IO.StreamReader file =
               new System.IO.StreamReader(fullPath);

            // Deserialize the content of the file into a Book object.
            LoadObj =  reader.Deserialize(file) ;
            reader = null;
            file.Close();
            file = null;
            return obj;
        }
    }
}
