using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("contactsharerule")
    [XmlRoot("results")]
    public class ContactShareRuleList : BaseApiWrappedList<ContactShareRule>
    {
        [XmlArray("contactShareRules")]
        [XmlArrayItem("contactShareRule")]
        public new List<ContactShareRule>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}