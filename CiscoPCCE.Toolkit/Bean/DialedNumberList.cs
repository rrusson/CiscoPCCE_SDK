using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("dialednumber")
    [XmlRoot("results")]
    public class DialedNumberList : BaseApiBean
    {
        [XmlArray("dialedNumbers")]
        [XmlArrayItem("dialedNumber")]
        public List<DialedNumber>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }

        // Path("dialednumber")
        [XmlRoot("results")]
        public class DialedNumberListList : BaseApiListBean<DialedNumberList>
        {
            public override List<DialedNumberList>? GetItems() => Items;

            public override void SetItems(List<DialedNumberList>? value) => Items = value;
        }
    }
}