using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("syncStatus")]
    public class SyncStatus : BaseApiBean
    {
        [XmlElement("currentSyncStatus")]
        public string? CurrentSyncStatus { get; set; }

        [XmlElement("lastSyncStats")]
        public string? LastSyncStats { get; set; }

        [XmlElement("lastSyncStatus")]
        public string? LastSyncStatus { get; set; }

        [XmlElement("lastSyncTime")]
        public string? LastSyncTime { get; set; }
    }
}