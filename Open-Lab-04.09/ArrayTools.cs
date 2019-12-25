using System;
using System.Collections.Generic;

namespace Open_Lab_04._09
{
    public class ArrayTools
    {
        public string[] RemoveDups(string[] strings)
        {
            var list = new List<string>();


            for (int i = 0; i < strings.Length; i++)
            {
                if (list.Contains(strings[i]) == false)
                {
                    list.Add(strings[i]);
                }
            }
            return list.ToArray();           
        }
    }
}
