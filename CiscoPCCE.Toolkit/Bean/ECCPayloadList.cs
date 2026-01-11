using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("/eccpayload")
    [XmlRoot("results")]
    public class ECCPayloadList : BaseApiBean
    {
        [XmlArray("eccpayloads")]
        [XmlArrayItem("eccpayload")]
        public List<ECCPayload>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }

        // Path("/eccpayload")
        [XmlRoot("results")]
        public class ECCPayloadListList : BaseApiListBean<ECCPayloadList>
        {
            [XmlArray("resultss")]
            [XmlArrayItem("results")]
            public new List<ECCPayloadList>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<ECCPayloadList>? GetItems() => Items;

            public override void SetItems(List<ECCPayloadList>? value) => Items = value;
        }
    }
}