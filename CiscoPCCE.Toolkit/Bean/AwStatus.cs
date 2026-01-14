using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("awStatus")]
    public class AwStatus : BaseApiBean
    {
        [XmlElement("##default")]
        public double? LastRetrievalKey { get; set; }
    }
}