using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace BootCDNAPIDemo
{
    public class StCloud
    {
        private static StCloud stCloud;
        public static StCloud GetSingle()
        {
            if(stCloud == null)
            {
                stCloud = new StCloud();
            }
            return stCloud;
        }
        private HttpClient httpClient;
        private string baseUrl => "https://api.bootcdn.cn/";
        private StCloud()
        {
            this.httpClient = new HttpClient();
        }
        private string Get(string api)
        {
            string url = $"{this.baseUrl}{api}";
            string content = this.httpClient.GetStringAsync(url).Result;
            return content;
        }
        /// <summary>
        /// 获取所有开源库简要信息列表
        /// </summary>
        /// <returns></returns>
        public LibrariesModels GetLibraries()
        {
            string content = this.Get("libraries.min.json");
            LibrariesModels lst = new LibrariesModels(content);
            return lst;
        }
        /// <summary>
        /// 获取开源库名称列表
        /// </summary>
        /// <returns></returns>
        public List<string> GetNames()
        {
            string content = this.Get("names.min.json");
            List<string> lst = JsonConvert.DeserializeObject<List<string>>(content);
            return lst;
        }
        public DetailedModel GetDetailedByName(string name)
        {
            string content = this.Get($"libraries/{name}.min.json");
            DetailedModel model = JsonConvert.DeserializeObject<DetailedModel>(content);
            return model;
        }
    }
}
