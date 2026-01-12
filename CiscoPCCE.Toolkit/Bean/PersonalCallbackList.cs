using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
// Path("personalcallback")
[XmlRoot("results")]
public class PersonalCallbackList : BaseApiList<PersonalCallback>
{
    [XmlArray("personalCallbacks")]
    [XmlArrayItem("personalCallback")]
    public new List<PersonalCallback>? Items
    {
        get => base.Items;
        set => base.Items = value;
    }
}
}
