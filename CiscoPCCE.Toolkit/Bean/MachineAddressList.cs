using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
// Path("machineinventory")
[XmlRoot("results")]
public class MachineAddressList : BaseApiList<MachineAddress>
{
    [XmlArray("addresss")]
    [XmlArrayItem("address")]
    public new List<MachineAddress>? Items
    {
        get => base.Items;
        set => base.Items = value;
    }
}
}
