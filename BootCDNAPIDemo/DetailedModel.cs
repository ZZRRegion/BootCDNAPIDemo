using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCDNAPIDemo
{
    public class DetailedModel
    {
        public string name { get; set; }
        public string npmName { get; set; }
        public string version { get; set; }
        public string description { get; set; }
        public string homepage { get; set; }
        public List<string> keywords { get; set; }
        public string license { get; set; }
        public Repository repository { get; set; }
        public List<Asset> assets { get; set; }
        public string stars { get; set; }
    }
    public class Repository
    {
        public string type { get; set; }
        public string url { get; set; }
    }
    public class Asset
    {
        public string version { get; set; }
        public List<string> files { get; set; }
    }
}
