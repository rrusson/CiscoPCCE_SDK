using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("sso")
    [XmlRoot("idsStatus")]
    public class IdsStatus : BaseApiBean
    {
        [XmlElement("state")]
        public string? State { get; set; }

        // Path("sso")
        [XmlRoot("results")]
        public class IdsStatusList : BaseApiListBean<IdsStatus>
        {
            public override List<IdsStatus>? GetItems() => Items;

            public override void SetItems(List<IdsStatus>? value) => Items = value;
        }
    }
}