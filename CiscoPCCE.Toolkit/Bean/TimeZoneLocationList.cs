using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("timezone")
    [XmlRoot("results")]
    public class TimeZoneLocationList : BaseApiWrappedList<TimeZoneLocation>
    {
        [XmlArray("timezones")]
        [XmlArrayItem("timezone")]
        public new List<TimeZoneLocation>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}