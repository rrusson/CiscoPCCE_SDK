using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("businesstimezone")
    [XmlRoot("results")]
    public class BusinessTimeZoneList : BaseApiList<BusinessTimeZone>
    {
        [XmlArray("businesstimezones")]
        [XmlArrayItem("businesstimezone")]
        public new List<BusinessTimeZone>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}