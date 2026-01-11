using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("reasoncode")
    [XmlRoot("results")]
    public class ReasonCodeList : BaseApiBean
    {
        [XmlArray("reasonCodes")]
        [XmlArrayItem("reasonCode")]
        public List<ReasonCode>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }

        // Path("reasoncode")
        [XmlRoot("results")]
        public class ReasonCodeListList : BaseApiListBean<ReasonCodeList>
        {
            [XmlArray("resultss")]
            [XmlArrayItem("results")]
            public new List<ReasonCodeList>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<ReasonCodeList>? GetItems() => Items;

            public override void SetItems(List<ReasonCodeList>? value) => Items = value;
        }
    }
}