using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    public class VMDatastoreData : BaseApiBean
    {
        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("sizeInGB")]
        public long? SizeInGB { get; set; }

        [XmlElement("usagePercentage")]
        public double UsagePercentage { get; set; }
    }
}