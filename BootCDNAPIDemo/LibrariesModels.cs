using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace BootCDNAPIDemo
{
    /// <summary>
    /// 开源库简要信息列表
    /// </summary>
    public class LibrariesModels
    {
        public List<LibrariesModel> ListLibraries { get; set; } = new List<LibrariesModel>();
        public LibrariesModels(string content)
        {
            JArray json = JArray.Parse(content);
            foreach(JArray jitem in json)
            {
                LibrariesModel model = new LibrariesModel(jitem);
                this.ListLibraries.Add(model);
            }
        }
    }
    public class LibrariesModel
    {
        public string name { get; set; }
        public string desc { get; set; }
        public string stars { get; set; }
        public LibrariesModel(JArray jitem)
        {
            this.name = jitem[0].ToString();
            this.desc = jitem[1].ToString();
            this.stars = jitem[2].ToString();
        }
        public override string ToString()
        {
            return this.name;
        }
    }
}
