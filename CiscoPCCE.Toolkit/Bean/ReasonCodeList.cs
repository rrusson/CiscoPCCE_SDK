using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("reasoncode")
    [XmlRoot("results")]
    public class ReasonCodeList : BaseApiList<ReasonCode>
    {
        [XmlArray("reasonCodes")]
        [XmlArrayItem("reasonCode")]
        public new List<ReasonCode>? Items
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