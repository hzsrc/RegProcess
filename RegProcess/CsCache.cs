using System;
using System.Collections.Generic;
using System.Reflection;

namespace RegProcess
{
    public class CsCache
    {
        private static CsCache _unique = new CsCache();

        private Dictionary<RepItem, MethodInfo> _objs = new Dictionary<RepItem, MethodInfo>();

        public static CsCache Unique
        {
            get
            {
                return _unique;
            }
        }

        public MethodInfo GetMethod(RepItem key, bool forceRebuild)
        {
            if (forceRebuild || !_objs.TryGetValue(key, out MethodInfo mi))
            {
                mi = CsBuilder.GetMethod(key);
                _objs[key] = mi;
            }
            return mi;
        }

        private CsCache()
        {
        }

        internal void Clear()
        {
            _objs.Clear();
        }
    }
}
