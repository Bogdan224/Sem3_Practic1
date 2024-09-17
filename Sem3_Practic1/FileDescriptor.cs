using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem3_Practic1
{
    internal class FileDescriptor
    {
        public string path {  get; set; }
        public List<MyFile> files { get; set; }

        public FileDescriptor(string path, List<MyFile> files)
        {
            this.path = path;
            this.files = files;
        }
    }
}
