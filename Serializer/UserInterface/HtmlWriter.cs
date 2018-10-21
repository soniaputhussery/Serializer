using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using UserInterface.Models;
using File = UserInterface.Models.File;

namespace UserInterface
{
    public class HtmlWriter : IWriter
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

            String body = buildBody(logData);

            using (FileStream fs = new FileStream(targetFile, FileMode.Create))
            {
                using (StreamWriter w = new StreamWriter(fs, Encoding.UTF8))
                {
                    using (HtmlTextWriter writer = new HtmlTextWriter(w))
                    {
                        writer.WriteLine("<!DOCTYPE html>");
                        writer.RenderBeginTag(HtmlTextWriterTag.Html);
                        writer.RenderBeginTag(HtmlTextWriterTag.Head);
                        writer.RenderBeginTag("title");
                        writer.Write("Activity Log");
                        writer.RenderEndTag();
                        writer.RenderEndTag();

                        writer.RenderBeginTag(HtmlTextWriterTag.Body);
                        //writer.RenderBeginTag(HtmlTextWriterTag.Table);
                        writer.Write(body);
                        writer.RenderEndTag();

                        writer.RenderEndTag();

                    }
                }
            }
        }

        private string buildBody(LogData logData)
        {
            List<File> files = logData.File;
            List<string> datas = logData.DataSection.Data;
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine("<h1>Metadata</h1>\n");
            sb.AppendLine("\t <table border=\"1\">\n");
            sb.AppendLine("\t\t<tr>\n");
            sb.AppendLine("\t\t\t<th>File</th><th>Code</th><th>Description</th>\n");
            sb.AppendLine("\t\t</tr>\n");
            foreach (File file in files)
            {
                sb.AppendLine("\t\t<tr>\n");
                sb.AppendLine("\t\t\t<td>"+ file.Name + "</td><td>"+ file.Code + "</td><td>" + file.Description + "</td>\n");
                sb.AppendLine("\t\t</tr>\n");
            }
            sb.AppendLine("\t</table>");
            sb.AppendLine("\t\t<h1>Activity Data</h1>\n");
            sb.AppendLine("\t <table border=\"1\">\n");
            sb.AppendLine("\t\t<tr>\n");
            sb.Append("\t\t\t<th>Time</th>");
            foreach (File file in files)
            {
                sb.Append("<th>" + file.Code + "</th>");
            }
            sb.AppendLine();
            sb.AppendLine("\t\t</tr>\n");
            for (int i = 0; i < datas.Count; i++)
            {
                string[] dataContents = datas[i].Split(',');
                sb.AppendLine("\t\t<tr>");
                sb.Append("\t\t\t");
                for (int j=0; j < dataContents.Length;j++)
                {
                    sb.Append("<td>" + dataContents[j] + "</td>");
                }
                sb.AppendLine();
                sb.AppendLine("\t\t</tr>\n");
            }
            sb.AppendLine("\t</table>");
            return sb.ToString();
        }
    }
}
