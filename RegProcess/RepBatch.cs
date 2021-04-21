using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;

namespace RegProcess
{
    public class RepBatch : IComparable<RepBatch>
    {
        public RepBatch()
        {
            Items = new List<RepItem>();
        }
        public List<RepItem> Items { get; set; }

        public string Title { get; set; }
        public int Order { get; set; }

        public string ReplaceBat(string input)
        {
            foreach (RepItem item in Items)
            {
                input = item.Replace(input);
            }
            return input;
        }

        public string GetCfgFile(string dir)
        {
            return Path.Combine(dir, GetCfgPattern(Title));
        }
        public static string GetCfgPattern(string title)
        {
            return "rep_" + title + ".json";
        }

        public int CompareTo(RepBatch other)
        {
            return this.Order - other.Order;
        }
    }
}
