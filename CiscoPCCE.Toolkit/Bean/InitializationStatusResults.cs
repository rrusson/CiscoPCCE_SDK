using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("results")]
    public class InitializationStatusResults : BaseApiBean
    {
        [XmlElement("state")]
        public StateEnum State { get; set; }

        [XmlArray("initializationStatuses")]
        [XmlArrayItem("initializationStatus")]
        public List<InitializationStatus>? StatusList { get; set; }
    }
}