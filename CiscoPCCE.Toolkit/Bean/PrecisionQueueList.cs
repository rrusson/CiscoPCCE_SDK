using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
// Path("precisionqueue")
[XmlRoot("results")]
public class PrecisionQueueList : BaseApiList<PrecisionQueue>
{
    [XmlArray("precisionQueues")]
    [XmlArrayItem("precisionQueue")]
    public new List<PrecisionQueue>? Items
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
