using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("sso")
    [XmlRoot("SsoConfig")]
    public class SsoConfigBean : BaseApiBean
    {
        [XmlElement("client_id")]
        public string? Client_id { get; set; }

        [XmlElement("client_secret")]
        public string? Client_secret { get; set; }

        [XmlElement("cluster_mode")]
        public string? Cluster_mode { get; set; }

        [XmlElement("cluster_name")]
        public string? Cluster_name { get; set; }

        [XmlElement("default_ids_ref")]
        public string? Default_ids_ref { get; set; }

        [XmlElement("ids1_url")]
        public string? Ids1_url { get; set; }

        [XmlElement("ids2_url")]
        public string? Ids2_url { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("redirect_base_uri")]
        public string? Redirect_base_uri { get; set; }

        [XmlElement("resource_id")]
        public string? Resource_id { get; set; }

        [XmlElement("resource_secret")]
        public string? Resource_secret { get; set; }
        
    }
}