using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("agent")
    [XmlRoot("results")]
    public class PersonList : BaseApiBean
    {
        [XmlElement("persons")]
        [XmlElement("person")]
        public List<Person>? Items { get; set; }

        public required PageInfo PageInfo { get; set; }

        public required PermissionInfo PermissionInfo { get; set; }

        // Path("agent")
        [XmlRoot("results")]
        public class PersonListList : BaseApiListBean<PersonList>
        {
            public override List<PersonList>? GetItems() => Items;

            public override void SetItems(List<PersonList>? value) => Items = value;
        }
    }
}