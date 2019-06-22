using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business_logic_3_
{
   public class GraphFunctions
    {
        public bool CheckGuard(IList<NodeGraph> List,int EndTime)
        {
            int[] GuardTime = new int[EndTime];

            for (int i = 0; i <GuardTime.Length; i++)
            {
                GuardTime[i] = 0;
            }

            for (int i = 0; i < List.Count; i++)
            {
                for (int j = 0; j < List[i].WorkTime.Length; j++)
                {
                    if (List[i].WorkTime[j][0] > EndTime)
                        continue;
                    if (List[i].WorkTime[j][1] > EndTime)
                    {
                        for (int k = List[i].WorkTime[j][0]; k < EndTime; k++)
                        {
                            GuardTime[k]++;
                        }
                    }
                    else
                    {
                        for (int k = List[i].WorkTime[j][0]; k < List[i].WorkTime[j][1]; k++)
                        {
                            GuardTime[k]++;
                        }
                    }
                }
            }
            for (int i = 0; i < GuardTime.Length; i++)
            {
                if (GuardTime[i] < 2)
                    return false;
            }
            return true;
        }
        public Dictionary<int, int> CheckBadGuardAreas(IList<NodeGraph> List, int EndTime)
        {
            int[] GuardTime = new int[EndTime];

            for (int i = 0; i < GuardTime.Length; i++)
            {
                GuardTime[i] = 0;
            }

            for (int i = 0; i < List.Count; i++)
            {
                for (int j = 0; j < List[i].WorkTime.Length; j++)
                {
                    if (List[i].WorkTime[j][0] > EndTime)
                        continue;
                    if (List[i].WorkTime[j][1] > EndTime)
                    {
                        for (int k = List[i].WorkTime[j][0]; k < EndTime; k++)
                        {
                            GuardTime[k]++;
                        }
                    }
                    else
                    {
                        for (int k = List[i].WorkTime[j][0]; k < List[i].WorkTime[j][1]; k++)
                        {
                            GuardTime[k]++;
                        }
                    }
                }
            }
            Dictionary<int, int> Result = new Dictionary<int, int>();
            for (int i = 0; i < GuardTime.Length; i++)
            {
                if (GuardTime[i] < 2)
                    Result[i] = GuardTime[i];
            }
            return Result;
        }

        public  List<string> DictionaryToStringArray(Dictionary<int, int> dictionary)
        {
            List<string> Lines = new List<string>();
            int check = -1;
            int start = -1;
            int end = -1;
            foreach(KeyValuePair<int, int> entry in dictionary)
            {
                if(check==-1)
                {
                    check = entry.Value;
                    start = entry.Key;
                    end= entry.Key;
                }
                if ((check != entry.Value) || (entry.Key - end > 1) || (dictionary.ElementAt(dictionary.Count - 1).Key == entry.Key))
                {
                    
                    if(dictionary.ElementAt(dictionary.Count - 1).Key ==entry.Key)
                        end = entry.Key;

                        string tmp = "[";
                        tmp += start.ToString();
                        tmp += "-";
                        tmp += end.ToString();
                        tmp += "] ";
                        tmp += check.ToString();
                        tmp += " Сторож";
                        Lines.Add(tmp);
                        check = -1;
                        start = -1;
                        end = -1; 
                }

                if(end!=-1)
                end= entry.Key;
            }
            return Lines;
        }  
    }
    
    
        
}
