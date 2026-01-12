using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
// Path("sso")
[XmlRoot("results")]
public class SsoConfigBeanList : BaseApiList<SsoConfigBean>
{
    [XmlArray("SsoConfigs")]
    [XmlArrayItem("SsoConfig")]
    public new List<SsoConfigBean>? Items
    {
        get => base.Items;
        set => base.Items = value;
    }
}
}
