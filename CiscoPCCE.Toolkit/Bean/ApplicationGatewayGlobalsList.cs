using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
// Path("applicationgatewayglobalsetting")
[XmlRoot("results")]
public class ApplicationGatewayGlobalsList : BaseApiList<ApplicationGatewayGlobals>
{
    [XmlArray("applicationGatewayGlobalSettings")]
    [XmlArrayItem("applicationGatewayGlobalSetting")]
    public new List<ApplicationGatewayGlobals>? Items
    {
        get => base.Items;
        set => base.Items = value;
    }

    [XmlElement("permissionInfo")]
    public required PermissionInfo PermissionInfo { get; set; }
}
}
