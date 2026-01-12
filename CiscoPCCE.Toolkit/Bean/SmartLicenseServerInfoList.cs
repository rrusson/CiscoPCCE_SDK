using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
// Path("smartlicense")
[XmlRoot("results")]
public class SmartLicenseServerInfoList : BaseApiList<SmartLicenseServerInfo>
{
    [XmlArray("smartlicenseserverinfos")]
    [XmlArrayItem("smartlicenseserverinfo")]
    public new List<SmartLicenseServerInfo>? Items
    {
        get => base.Items;
        set => base.Items = value;
    }
}
}
