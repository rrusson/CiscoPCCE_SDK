using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("locationproperties")
    [XmlRoot("locationProperties")]
    public class LocationProperties : BaseApiBean
    {
        [XmlElement("locationRoutingCodeInsertOption")]
        public string? LocationRoutingCodeInsertOption { get; set; }

        // Path("locationproperties")
        [XmlRoot("results")]
        public class LocationPropertiesList : BaseApiListBean<LocationProperties>
        {
            [XmlArray("locationPropertiess")]
            [XmlArrayItem("locationProperties")]
            public new List<LocationProperties>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<LocationProperties>? GetItems() => Items;

            public override void SetItems(List<LocationProperties>? value) => Items = value;
        }
    }
}