using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterface.Models;
using File = UserInterface.Models.File;

namespace UserInterface
{
    class ExtractData
    {
        public LogData getData(String sourceFile)
        {
            LogData logData = new LogData();
            File file = new File();
            DataSection dataSection = new DataSection();
            List<String> myData = new List<String>();


            String[] terms = sourceFile.Split('\\');
            file.Name = terms[terms.Length - 1];


            using (StreamReader sr = new StreamReader(sourceFile))
            {
                String line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Equals("[Code]"))
                    {
                        file.Code = dataSection.ParamList = sr.ReadLine();
                    }

                    if (line.Equals("[Description]"))
                    {
                        file.Description = sr.ReadLine();
                    }

                    if (line.Equals("[Data]"))
                    {
                        while ((line = sr.ReadLine()) != null)
                        {
                            myData.Add(line);
                        }
                        break;
                    }
                }
            }

            dataSection.Data = myData;
            logData.File = new List<File>();
            logData.File.Add(file);
            logData.DataSection = dataSection;
            return logData;
        }

        
        public LogData mergeLogData(List<LogData> logDatas)
        {
            
            LogData logData = new LogData();
            DataSection dataSection = new DataSection();
            logData.File = new List<File>();
            List<string> tempData = new List<string>();
            dataSection.Data = new List<string>();
            Dictionary<int, List<String>> keysMap = new Dictionary<int, List<String>>();
            Dictionary<String, String> valuesMap = new Dictionary<String, String>();

            for (int i = 0; i < logDatas.Count; i++)
            {
                File file = new File();
                file = logDatas[i].File[0];
                logData.File.Add(file);
                
                dataSection.ParamList += logDatas[i].DataSection.ParamList + ",";

                List<String> keys = new List<String>();

                for (int j = 0; j < logDatas[i].DataSection.Data.Count; j++)
                {
                     String[] terms = logDatas[i].DataSection.Data[j].Split(',');
                     keys.Add(terms[0]);
                    if (valuesMap.ContainsKey(terms[0]))
                    {
                        String valToAdd;
                        if (i > 1)
                        {
                            valToAdd = valuesMap[terms[0]] +","+ terms[1];
                        }
                        else
                        {
                             valToAdd = valuesMap[terms[0]] + terms[1];
                        }
                  
                        valuesMap.Remove(terms[0]);
                        valuesMap.Add(terms[0], valToAdd);
                    }
                    else
                    {
                        if (i > 0)
                        {
                            valuesMap.Add(terms[0],","+ terms[1]);
                        }
                        else
                        {
                            valuesMap.Add(terms[0], terms[1]+",");
                        }
                       
                    }
                }
                keysMap.Add(i, keys);
            }

            dataSection.ParamList = dataSection.ParamList.Substring(0, dataSection.ParamList.Length - 1);
            dataSection.Data = mergeData(keysMap, valuesMap);
            logData.DataSection = dataSection;
            return logData;
        }
        public List<String> mergeData(Dictionary<int, List<String>> keysMap, Dictionary<String, String> valuesMap)
        {
            {
                List<String> result = new List<string>();
                CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");
               
                var enumeratorKeyValues = valuesMap.GetEnumerator();
                while (enumeratorKeyValues.MoveNext())
                {
                    var pair = enumeratorKeyValues.Current;
                    String[] dateTime = pair.Key.Split('T');
                    int timeTrimIndex = dateTime[1].LastIndexOf('.');
                    if (timeTrimIndex > 0)
                    {
                        dateTime[1] = dateTime[1].Substring(0, timeTrimIndex);
                    }
                    String dataToParse = dateTime[0] + " " + dateTime[1];
                    var date = DateTime.ParseExact(dataToParse, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                                     
                    result.Add(date.ToString("G", culture)+" +00:00" + "," + pair.Value);//  G Format Specifier en-US Culture 10/1/2008 5:04:32 PM
                }
                return result;
            }

        }
    }
}

    
        
    
