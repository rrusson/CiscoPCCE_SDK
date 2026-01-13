using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("/eccpayload")
    [XmlRoot("results")]
    public class ECCPayloadList : BaseApiList<ECCPayload>
    {
        [XmlArray("eccpayloads")]
        [XmlArrayItem("eccpayload")]
        public new List<ECCPayload>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }
    }
}