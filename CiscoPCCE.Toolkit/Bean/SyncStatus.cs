using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("syncStatus")]
    public class SyncStatus : BaseApiBean
    {
        public string? CurrentSyncStatus { get; set; }

        public string? LastSyncStats { get; set; }

        public string? LastSyncStatus { get; set; }

        public string? LastSyncTime { get; set; }
    }
}