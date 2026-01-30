using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("contactsharegroup")
    [XmlRoot("results")]
    public class ContactShareGroupList : BaseApiWrappedList<ContactShareGroup>
    {
        [XmlArray("contactShareGroups")]
        [XmlArrayItem("contactShareGroup")]
        public new List<ContactShareGroup>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}