using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
// Path("sipservergroupproperties")
[XmlRoot("results")]
public class CVPSIPServerGroupPropertiesList : BaseApiList<CVPSIPServerGroupProperties>
{
    [XmlArray("CVPs")]
    [XmlArrayItem("CVP")]
    public new List<CVPSIPServerGroupProperties>? Items
    {
        get => base.Items;
        set => base.Items = value;
    }
}
}
