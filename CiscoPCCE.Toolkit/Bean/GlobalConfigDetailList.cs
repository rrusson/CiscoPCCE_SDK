using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
// Path("contactcenterai")
[XmlRoot("results")]
public class GlobalConfigDetailList : BaseApiList<GlobalConfigDetail>
{
    [XmlArray("globalConfigDetails")]
    [XmlArrayItem("globalConfigDetail")]
    public new List<GlobalConfigDetail>? Items
    {
        get => base.Items;
        set => base.Items = value;
    }
}
}
