using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("timezone")
    [XmlRoot("results")]
    public class TimeZoneList : BaseApiWrappedList<TimeZone>
    {
        [XmlArray("timeZones")]
        [XmlArrayItem("timeZone")]
        public new List<TimeZone>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}