using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
// Path("registry")
[XmlRoot("results")]
public class RegistryList : BaseApiList<Registry>
{
    [XmlArray("registrys")]
    [XmlArrayItem("registry")]
    public new List<Registry>? Items
    {
        get => base.Items;
        set => base.Items = value;
    }
}
}
