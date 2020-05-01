using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9
{
    class PageInfo
    {
        public int Index { get; set; }
        public string URL { get; set; }
        public string Status { get; set; }

        public PageInfo(int index, string url, string status)
        {
            Index = index;
            URL = url;
            Status = status;
        }
    }
}
