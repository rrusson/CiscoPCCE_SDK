using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("sso")
    [XmlRoot("SsoState")]
    public class SsoStateBean : BaseApiBean
    {
        public string? Active_ids { get; set; }

        public string? Caching { get; set; }

        public string? Client_id { get; set; }

        public string? Default_ids_ref { get; set; }

        public string? Ids1_state { get; set; }

        public string? Ids2_state { get; set; }

        public string? Name { get; set; }

        public SsoLocalEnabledState Sso_mode { get; set; }

        public long? Timestamp { get; set; }

        // Path("sso")
        [XmlRoot("results")]
        public class SsoStateBeanList : BaseApiListBean<SsoStateBean>
        {
            public override List<SsoStateBean>? GetItems() => Items;

            public override void SetItems(List<SsoStateBean>? value) => Items = value;
        }
    }
}