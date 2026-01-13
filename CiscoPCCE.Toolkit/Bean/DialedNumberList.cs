using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("dialednumber")
    [XmlRoot("results")]
    public class DialedNumberList : BaseApiList<DialedNumber>
    {
        [XmlArray("dialedNumbers")]
        [XmlArrayItem("dialedNumber")]
        public new List<DialedNumber>? Items
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