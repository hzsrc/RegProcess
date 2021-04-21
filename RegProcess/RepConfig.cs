using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;

namespace RegProcess
{
    public class RepConfig
    {
        public static void Save(string dir, List<RepBatch> batches)
        {
            if (String.IsNullOrEmpty(dir))
            {
                dir = "";
            }
            foreach (var bat in batches)
            {
                File.WriteAllText(bat.GetCfgFile(dir), JSON.Stringify(bat));
            }
        }
        public static List<RepBatch> LoadDir(string dir)
        {
            var list = Directory.GetFiles(dir, RepBatch.GetCfgPattern("*"))
                    .Select(file => JSON.ParseFile<RepBatch>(file)).ToList();
            list.Sort();
            return list;
        }

        private static Dictionary<string, RepBatch> _cache = new Dictionary<string, RepBatch>();
        public static RepBatch Get(string configFile)
        {
            if (!_cache.TryGetValue(configFile, out RepBatch val))
            {

                val = JSON.ParseFile<RepBatch>(configFile);
                _cache[configFile] = val;
            }
            return val;
        }
    }
}
