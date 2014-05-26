using System;
using System.Collections;
using System.Text;

namespace TienX.License
{
    public class TienXUtils
    {
        public static Hashtable getProperties(string data)
        {
            var fileData = data.Replace("\r", "");
            var Properties = new Hashtable();
            var records = fileData.Split("\n".ToCharArray());
            foreach (string record in records)
            {
                var kvp = record.Split("=".ToCharArray());
                if (kvp != null && kvp.Length > 1 && !kvp[0].StartsWith("#"))
                {
                    Properties.Add(kvp[0], kvp[1]);
                }
            }
            return Properties;
        }
    }
}
