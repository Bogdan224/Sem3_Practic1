using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem3_Practic1
{
    internal class MyFile
    {
        public string name { get; set; }
        public string type { get; set; }
        public double size { get; set; }
        public string date { get; set; }

        public MyFile(string name, string type, double size, string date)
        {
            this.name = name;
            this.type = type;
            this.size = size;
            this.date = date;
        }
    }
}
