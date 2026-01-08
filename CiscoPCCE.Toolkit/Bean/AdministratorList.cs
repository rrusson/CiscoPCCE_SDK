using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("administrator")
    [XmlRoot("results")]
    public class AdministratorList : BaseApiBean
    {
        [XmlArray("administrators")]
        [XmlArrayItem("administrator")]
        public List<Administrator>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }

        // Path("administrator")
        [XmlRoot("results")]
        public class AdministratorListList : BaseApiListBean<AdministratorList>
        {
            [XmlArray("resultss")]
            [XmlArrayItem("results")]
            public new List<AdministratorList>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<AdministratorList>? GetItems() => Items;

            public override void SetItems(List<AdministratorList>? value) => Items = value;
        }
    }
}