using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    public class VMDatastore : BaseApiBean
    {
        [XmlElement("maxSizeInGB")]
        public long? MaxSizeInGB { get; set; }

        [XmlElement("minSizeInGB")]
        public long? MinSizeInGB { get; set; }

        [XmlElement("sizeInGB")]
        public long? SizeInGB { get; set; }

        [XmlArray("vmsToMatch")]
        [XmlArrayItem("vm")]
        public List<VMProfile>? VmsToMatch { get; set; }
    }
}