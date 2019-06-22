using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;
using System.Globalization;
using System.Diagnostics;


namespace Utils
{
    public class IOUtils
    {
        public static string[] ToStrArray(IList<string> lines)
        {
            string[] arr = new string[lines.Count];
            for (int i = 0; i < lines.Count; i++)
            {
                arr[i] = lines[i];
            }
            return arr;
        }
        // Функция конвертирует строку в значение T
        // (при невозможности конвертации происходит ошибка)
        public static T StrToValue<T>(string str) {
            return (T) Convert.ChangeType(str, typeof(T));
        }

        // Функция конвертирует строку в массив элементов T
        // (при невозможности конвертации происходит ошибка)
        public static T[] StrToArray<T>(string str)
        {
            return Array.ConvertAll(
                str.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries),
                (s) => StrToValue<T>(s)
            );
        }

        public static List<int> StringArrToIntArr(string[] lines)
        {
            List<int> list=new List<int>();
            for (int i = 0; i < lines.Length; i++)
            {
                //list.AddRange(<int>StrToArray(lines[i]);
            }
            return list;
        }

        // Функция конвертирует массив элементов T в строку
        // (вторым параметром можно указать разделитель, по умолчанию ", ")
        public static string ArrayToStr<T>(IList<T> arr, string separator = ", ") {
            return arr == null ? "null" : string.Join(separator, arr);
        }

        public static string[] ConvertToStringArr(IList<int> arr)
        {
            string[] lines = new string[arr.Count];
            for (int i = 0; i < arr.Count;++i)
            {
                lines[i] = arr[i].ToString();    
            }
            return lines;
        }
        public static string[] ConvertToStringArr_str(IList<string> arr)
        {
            string[] lines = new string[arr.Count];
            for (int i = 0; i < arr.Count; ++i)
            {
                lines[i] = arr[i].ToString();
            }
            return lines;
        }
        public static int[] ConvertToIntArr(string[] lines)
        {
            int[] arr = new int[lines.Length];
            for (int i = 0; i < lines.Length; ++i)
            {
                arr[i] = Convert.ToInt32(lines[i]);
            }
            return arr;
        }
        public static char[] ConvertToCharArr(IList<char> arr)
        {
            char[] lines = new char[arr.Count];
            for (int i = 0; i < arr.Count; ++i)
            {
                lines[i] = arr[i];
            }
            return lines;
        }
        public static byte[] ConvertToByteArr(List<byte> list)
        {
            byte[] arr = new byte[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                arr[i] = list[i];
            }
            return arr;
        }

        //public static string[] ConvertToStringArr(IList<int> arr)
        //{
        //    string[] lines = new string[arr.Count];
        //    for (int i = 0; i < arr.Count; ++i)
        //    {
        //        lines[i] = arr[i].ToString();
        //    }
        //    return lines;
        //}

       // public static int[] ConvertToIntArr(string[] lines)
       //{
       //   int[] arr = new int[lines.Length];
       //   for (int i = 0; i < lines.Length; ++i)
       //    {
       //        arr[i] = Convert.ToInt32(lines[i]);
       //    }
       //     return arr;
       // }

    }
}
