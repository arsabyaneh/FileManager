using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    public class FileType
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string[] Extensions { get; set; }
        public string[] SearchPattern { get; set; }
        public Image Image { get; set; }
    }
}
