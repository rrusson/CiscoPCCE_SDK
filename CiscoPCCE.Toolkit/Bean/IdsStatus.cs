using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

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
            [XmlArray("idsStatuss")]
            [XmlArrayItem("idsStatus")]
            public new List<IdsStatus>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<IdsStatus>? GetItems() => Items;

            public override void SetItems(List<IdsStatus>? value) => Items = value;
        }
    }
}