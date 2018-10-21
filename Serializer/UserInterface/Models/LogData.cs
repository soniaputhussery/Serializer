using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace UserInterface.Models
{
    public class LogData
    {
        [XmlElement("File")]
        public List<File> File { get; set; }
        public DataSection DataSection { get; set; }
    }

    public class File
    {
        [XmlAttribute]
        public String Name { get; set; }
        public String Code { get; set; }
        public String Description { get; set; }
    }

    public class DataSection
    {
        public String ParamList { get; set; }
        [XmlElement("Data")]
        public List<String> Data { get; set; }
    }

}
