using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterface.Models;
using File = UserInterface.Models.File;
using System.Xml.Serialization;
using System.IO;


namespace UserInterface
{
    public class XmlWriter : IWriter
    {
        public void write(List<String> sourceFile, String targetFile)
        {
            ExtractData obj = new ExtractData();
            List<LogData> logDatas = new List<LogData>();

            for (int i = 0; i < sourceFile.Count; i++)
            {
                logDatas.Add(new LogData());
                logDatas[i] = obj.getData(sourceFile[i]);
            }

            LogData logData = obj.mergeLogData(logDatas);
            using (StreamWriter sw = new StreamWriter(targetFile))
            {
                XmlSerializer XML = new XmlSerializer(typeof(LogData));
                XML.Serialize(sw, logData);
            }
        }
    }
}
