using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFdivvyWF
{
    public class Reformatter
    {
        public Reformatter()
        {
        }

        public static string resolveHeaders(string format,string[] header)
        {
            for (int field = 0; field < header.Length; field++)
                format = format.Replace("{" + header[field], "{" + field);
            return format;
        }
    }
}
