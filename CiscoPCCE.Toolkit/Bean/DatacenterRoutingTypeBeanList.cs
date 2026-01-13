using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("routingtype")
    [XmlRoot("results")]
    public class DatacenterRoutingTypeBeanList : BaseApiList<DatacenterRoutingTypeBean>
    {
        [XmlArray("datacenterRoutingTypes")]
        [XmlArrayItem("datacenterRoutingType")]
        public new List<DatacenterRoutingTypeBean>? Items
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