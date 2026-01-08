using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("agent")
    [XmlRoot("results")]
    public class PersonList : BaseApiBean
    {
        [XmlArray("persons")]
        [XmlArrayItem("person")]
        public List<Person>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
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