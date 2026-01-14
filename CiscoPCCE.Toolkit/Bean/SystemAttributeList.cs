using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("systemattribute")
    [XmlRoot("results")]
    public class SystemAttributeList : BaseApiList<SystemAttribute>
    {
        [XmlArray("systemAttributes")]
        [XmlArrayItem("systemAttribute")]
        public new List<SystemAttribute>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}