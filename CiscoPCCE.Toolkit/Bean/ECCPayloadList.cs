using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("/eccpayload")
    [XmlRoot("results")]
    public class ECCPayloadList : BaseApiBean
    {
        [XmlElement("eccpayloads")]
        [XmlElement("eccpayload")]
        public List<ECCPayload>? Items { get; set; }

        public required PageInfo PageInfo { get; set; }

        public required PermissionInfo PermissionInfo { get; set; }

        // Path("/eccpayload")
        [XmlRoot("results")]
        public class ECCPayloadListList : BaseApiListBean<ECCPayloadList>
        {
            public override List<ECCPayloadList>? GetItems() => Items;

            public override void SetItems(List<ECCPayloadList>? value) => Items = value;
        }
    }
}