using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("agent")
    [XmlRoot("results")]
    public class PersonList : BaseApiWrappedList<Person>
    {
        [XmlArray("persons")]
        [XmlArrayItem("person")]
        public new List<Person>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}