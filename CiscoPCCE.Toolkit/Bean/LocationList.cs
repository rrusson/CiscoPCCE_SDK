using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("location")
    [XmlRoot("results")]
    public class LocationList : BaseApiList<Location>
    {
        [XmlArray("locations")]
        [XmlArrayItem("location")]
        public new List<Location>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}