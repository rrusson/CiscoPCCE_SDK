using System.Xml.Serialization;

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
            public override List<ReasonCodeList>? GetItems() => Items;

            public override void SetItems(List<ReasonCodeList>? value) => Items = value;
        }
    }
}