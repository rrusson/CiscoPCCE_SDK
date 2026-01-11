using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

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
            [XmlArray("resultss")]
            [XmlArrayItem("results")]
            public new List<BusinessHourList>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<BusinessHourList>? GetItems() => Items;

            public override void SetItems(List<BusinessHourList>? value) => Items = value;
        }
    }
}