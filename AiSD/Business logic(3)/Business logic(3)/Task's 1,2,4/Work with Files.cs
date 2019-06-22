using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Utils;

namespace Business_logic_3_
{
    public class Work_with_Files
    {
        public string[] Lines { get;set; }
        public string InputFile { get;set; }
        public List<int> IntLines { get; set; }

        public Work_with_Files(string inputFile)
        {
            InputFile = inputFile;
            Lines = File.ReadAllLines(inputFile);
            List<int> intLines = new List<int>();
            for (int i = 0; i < Lines.Length; i++)
            {
               intLines.AddRange(IOUtils.StrToArray<int>(Lines[i])); 
            }
            IntLines = intLines;
        }
        public Work_with_Files()
        { }

        public string[] Load_str_numb()
        {
            List<int> list=new List<int>();
            for (int i = 0; i < Lines.Length; ++i)
            {      
                list.AddRange(IOUtils.StrToArray<int>(Lines[i]));
            }
            string[] sortlines=new string[list.Count];
            for (int i = 0; i < sortlines.Length; ++i)
            {
                sortlines[i] = list[i].ToString();
            }
                return sortlines;
        }

        public void SaveIntArr(string[] lines, string outputFile)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < lines.Length; ++i)
            {
                list.AddRange(IOUtils.StrToArray<int>(lines[i]));
            }
            string result="";
            for (int i = 0; i < list.Count; ++i)
            {
                if (i == 0)
                {
                    result += list[i].ToString();
                }
                else
                {
                    result += ", ";
                    result += list[i].ToString();
                } 
            }
            StreamWriter f = new StreamWriter(outputFile);
            f.Write(result);
            f.Close();
        }
    }
}
