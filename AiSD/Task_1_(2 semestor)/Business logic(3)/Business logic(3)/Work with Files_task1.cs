using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Business_logic_3_
{
    public class Work_with_Files
    {
        private string InputFile { get; set; }
        public string[] Lines {get;set;}

        public Work_with_Files(string inputFile)
        {
            InputFile = inputFile;
            Lines = File.ReadAllLines(inputFile, Encoding.Default); 
        }

        public int Find_paragraph()
        {
            bool key = false;
            int paragraph = 0;
            for (int i = 0; i < Lines.Length; ++i)
            {
                if (String.IsNullOrWhiteSpace(Lines[i]))
                {
                    if (key == false)
                    {
                        ++paragraph;
                        key = true;
                    }
                }
                else
                    key = false;
            }
            return paragraph;
        }
    }
}
