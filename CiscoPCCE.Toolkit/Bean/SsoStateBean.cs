using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("SsoState")]
    public class SsoStateBean : BaseApiBean
    {
        [XmlElement("active_ids")]
        public string? Active_ids { get; set; }

        [XmlElement("caching")]
        public string? Caching { get; set; }

        [XmlElement("client_id")]
        public string? Client_id { get; set; }

        [XmlElement("default_ids_ref")]
        public string? Default_ids_ref { get; set; }

        [XmlElement("ids1_state")]
        public string? Ids1_state { get; set; }

        [XmlElement("ids2_state")]
        public string? Ids2_state { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("sso_mode")]
        public SsoLocalEnabledState Sso_mode { get; set; }

        [XmlElement("timestamp")]
        public long? Timestamp { get; set; }
    }
}