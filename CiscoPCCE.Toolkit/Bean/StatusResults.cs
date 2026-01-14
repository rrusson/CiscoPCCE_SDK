using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("results")]
    public class StatusResults : BaseApiBean
    {
        [XmlArray("statuses")]
        [XmlArrayItem("status")]
        public List<Status>? Statuses { get; set; }
    }
}