using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
// Path("useridentity")
[XmlRoot("results")]
public class UserIdentityList : BaseApiList<UserIdentity>
{
    [XmlArray("userIdentitys")]
    [XmlArrayItem("userIdentity")]
    public new List<UserIdentity>? Items
    {
        get => base.Items;
        set => base.Items = value;
    }
}
}
