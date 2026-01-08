using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("businesshour")
    [XmlRoot("results")]
    public class BusinessHourList : BaseApiBean
    {
        [XmlArray("businessHours")]
        [XmlArrayItem("businessHour")]
        public List<BusinessHour>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }

        // Path("businesshour")
        [XmlRoot("results")]
        public class BusinessHourListList : BaseApiListBean<BusinessHourList>
        {
            public override List<BusinessHourList>? GetItems() => Items;

            public override void SetItems(List<BusinessHourList>? value) => Items = value;
        }
    }
}