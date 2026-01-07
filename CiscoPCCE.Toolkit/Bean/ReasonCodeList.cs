using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("reasoncode")
    [XmlRoot("results")]
    public class ReasonCodeList : BaseApiBean
    {
        [XmlElement("reasonCodes")]
        [XmlElement("reasonCode")]
        public List<ReasonCode>? Items { get; set; }

        public required PageInfo PageInfo { get; set; }

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