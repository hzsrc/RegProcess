using System;
using System.Reflection;
using System.Text.RegularExpressions;

namespace RegProcess
{
    public class RepItem
    {
        public bool Disabled { get; set; }

        public bool NoReg { get; set; }
        public string Title { get; set; } = "";

        public string Pattern { get; set; }

        public string RepalceTo { get; set; }

        public bool IgnoreCase { get; set; }

        public bool Global { get; set; }

        public bool Boundary { get; set; }

        public RepType RepType { get; set; }

        public bool HasPettern() { return Pattern != null; }

        private Regex _reg;
        private string _lastFeature;
        public string RepalceToRN()
        {
            if (RepalceTo == null)
            {
                return null;
            }
            return RepalceTo.Replace("\\r\\n", "\r\n");
        }

        private Regex BuildReg()
        {
            if (IsFeatureChanged())
            {
                RegexOptions regexOptions = RegexOptions.None;
                if (IgnoreCase)
                {
                    regexOptions |= RegexOptions.IgnoreCase;
                }
                if (!Global)
                {
                    regexOptions |= RegexOptions.Multiline;
                }
                _reg = new Regex(Boundary ? ("\\b" + Pattern + "\\b") : Pattern, regexOptions);
            }
            Console.WriteLine(_reg.ToString());
            return _reg;
        }

        public string Replace(string s)
        {
            if (!Disabled && HasPettern())
            {
                if (RepType == RepType.CS_Code)
                {
                    var changed = IsFeatureChanged();
                    MethodInfo mi = CsCache.Unique.GetMethod(this, changed);
                    if (changed)
                    {
                        ResetFeature(); //For BuidReg()
                    }
                    return BuildReg().Replace(s, (Match match) => Convert.ToString(mi.Invoke(null, new object[1]
                    {
                        match
                    })));
                }
                return BuildReg().Replace(s, RepalceToRN());
            }
            return s;
        }
        public void ResetFeature()
        {
            _lastFeature = "";
        }
        public bool IsFeatureChanged()
        {
            string feature = RepType + "," + IgnoreCase + "," + Global + "," + Boundary + "," + Pattern;
            if (_reg == null || feature != _lastFeature)
            {
                _lastFeature = feature;
                return true;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return RepalceTo.GetHashCode();
        }

        internal RepItem Clone()
        {
            return MemberwiseClone() as RepItem;
        }
    }
}
