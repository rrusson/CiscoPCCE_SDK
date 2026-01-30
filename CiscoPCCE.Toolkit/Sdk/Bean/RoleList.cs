using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("role")
    [XmlRoot("results")]
    public class RoleList : BaseApiWrappedList<Role>
    {
        [XmlArray("roles")]
        [XmlArrayItem("role")]
        public new List<Role>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}