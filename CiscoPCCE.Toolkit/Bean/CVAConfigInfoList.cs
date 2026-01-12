using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
// Path("machineinventory")
[XmlRoot("results")]
public class CVAConfigInfoList : BaseApiList<CVAConfigInfo>
{
    [XmlArray("speechConfigs")]
    [XmlArrayItem("speechConfig")]
    public new List<CVAConfigInfo>? Items
    {
        get => base.Items;
        set => base.Items = value;
    }
}
}
