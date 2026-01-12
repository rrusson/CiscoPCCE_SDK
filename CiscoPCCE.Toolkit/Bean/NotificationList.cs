using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
// Path("notifications")
[XmlRoot("results")]
public class NotificationList : BaseApiList<Notification>
{
    [XmlArray("##defaults")]
    [XmlArrayItem("##default")]
    public new List<Notification>? Items
    {
        get => base.Items;
        set => base.Items = value;
    }

    [XmlElement("permissionInfo")]
    public required PermissionInfo PermissionInfo { get; set; }
}
}
