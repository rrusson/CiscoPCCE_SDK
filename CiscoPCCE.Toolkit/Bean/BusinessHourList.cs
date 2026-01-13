using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("businesshour")
    [XmlRoot("results")]
    public class BusinessHourList : BaseApiList<BusinessHour>
    {
        [XmlArray("businessHours")]
        [XmlArrayItem("businessHour")]
        public new List<BusinessHour>? Items
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