using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
// Path("administrator")
[XmlRoot("results")]
public class UserGroupBaseList : BaseApiList<UserGroupBase>
{
    [XmlArray("userGroupBases")]
    [XmlArrayItem("userGroupBase")]
    public new List<UserGroupBase>? Items
    {
        get => base.Items;
        set => base.Items = value;
    }
}
}
