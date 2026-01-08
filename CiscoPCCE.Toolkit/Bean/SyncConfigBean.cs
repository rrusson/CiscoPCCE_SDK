using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("syncConfig")]
    public class SyncConfigBean : BaseApiBean
    {
        [XmlElement("enabled")]
        public bool? Enabled { get; set; }

        [XmlElement("endTime")]
        public string? EndTime { get; set; }

        [XmlElement("frequency")]
        public int? Frequency { get; set; }

        [XmlArray("groups")]
        [XmlArrayItem("group")]
        public List<string?>? Groups { get; set; }

        [XmlElement("startTime")]
        public string? StartTime { get; set; }
    }
}