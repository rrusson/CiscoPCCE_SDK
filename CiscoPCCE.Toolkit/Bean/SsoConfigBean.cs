using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("sso")
    [XmlRoot("SsoConfig")]
    public class SsoConfigBean : BaseApiBean
    {
        public string? Client_id { get; set; }

        public string? Client_secret { get; set; }

        public string? Cluster_mode { get; set; }

        public string? Cluster_name { get; set; }

        public string? Default_ids_ref { get; set; }

        public string? Ids1_url { get; set; }

        public string? Ids2_url { get; set; }

        public string? Name { get; set; }

        public string? Redirect_base_uri { get; set; }

        public string? Resource_id { get; set; }

        public string? Resource_secret { get; set; }

        // Path("sso")
        [XmlRoot("results")]
        public class SsoConfigBeanList : BaseApiListBean<SsoConfigBean>
        {
            public override List<SsoConfigBean>? GetItems() => Items;

            public override void SetItems(List<SsoConfigBean>? value) => Items = value;
        }
    }
}