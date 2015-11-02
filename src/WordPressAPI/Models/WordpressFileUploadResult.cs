using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XmlRpcPortable.Converter;
using XmlRpcPortable.Models;

namespace WordPressAPI.Models
{
    [XmlRpcType(typeof(XmlRpcStruct))]
    public class WordpressFileUploadResult
    {
        [XmlRpcName("id")]
        public string Id { get; set; }

        [XmlRpcName("file")]
        public string Name { get; set; }

        [XmlRpcName("url")]
        public string Url { get; set; }

        [XmlRpcName("type")]
        public string Type { get; set; }
    }
}
