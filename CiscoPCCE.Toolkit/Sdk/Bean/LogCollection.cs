using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("logCollection")]
    public class LogCollection : BaseApiBean
    {
        [XmlElement("components")]
        [XmlElement("component")]
        public required Set Components { get; set; }

        [XmlElement("description")]
        public string? Description { get; set; }

        [XmlElement("endDateTime")]
        public long? EndDateTime { get; set; }

        [XmlElement("##default")]
        public required FileRefWithSize ResultsFile { get; set; }

        [XmlElement("startDateTime")]
        public long? StartDateTime { get; set; }

        [XmlElement("status")]
        public required Status Status { get; set; }
    }
}