using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("##default")]
    public class InternetScriptEditor : BaseApiBean
    {
        [XmlElement("downloadLink")]
        public string? DownloadLink { get; set; }

        [XmlElement("enabled")]
        public bool? Enabled { get; set; }
    }
}