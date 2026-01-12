using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
// Path("timezone")
[XmlRoot("results")]
public class TimeZoneLocationList : BaseApiList<TimeZoneLocation>
{
    [XmlArray("timezones")]
    [XmlArrayItem("timezone")]
    public new List<TimeZoneLocation>? Items
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
