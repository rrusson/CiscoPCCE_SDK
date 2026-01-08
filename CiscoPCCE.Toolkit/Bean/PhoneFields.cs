using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    public class PhoneFields : BaseApiBean
    {
        [XmlElement("callResult")]
        public int CallResult { get; set; }

        [XmlElement("dstObserved")]
        public bool? DstObserved { get; set; }

        [XmlElement("gmtOffset")]
        public int GmtOffset { get; set; }

        [XmlElement("number")]
        public string? Number { get; set; }
    }
}