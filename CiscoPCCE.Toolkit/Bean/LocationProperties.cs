using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("locationproperties")
    [XmlRoot("locationProperties")]
    public class LocationProperties : BaseApiBean
    {
        public string? LocationRoutingCodeInsertOption { get; set; }

        // Path("locationproperties")
        [XmlRoot("results")]
        public class LocationPropertiesList : BaseApiListBean<LocationProperties>
        {
            public override List<LocationProperties>? GetItems() => Items;

            public override void SetItems(List<LocationProperties>? value) => Items = value;
        }
    }
}