using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XmlRpcPortable.Converter;
using XmlRpcPortable.Models;

namespace WordPressAPI.Models
{
    [XmlRpcType(typeof(XmlRpcStruct))]
    public class WordpressFile
    {
        [XmlRpcName("name")]
        public string Name { get; set; }

        [XmlRpcName("type")]
        public string Type { get; set; }

        [XmlRpcName("bits")]
        [XmlRpcType(typeof(XmlRpcBinary))]
        public MemoryStream Bits { get; set; }

        [XmlRpcName("overwrite")]
        public bool Overwrite { get; set; }

        [XmlRpcName("post_id")]
        public int PostId { get; set; }
    }
}
