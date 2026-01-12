using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("locationproperties")
    [XmlRoot("results")]
    public class LocationPropertiesList : BaseApiList<LocationProperties>
    {
        [XmlArray("locationPropertiess")]
        [XmlArrayItem("locationProperties")]
        public new List<LocationProperties>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}