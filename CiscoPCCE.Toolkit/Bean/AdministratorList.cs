using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("administrator")
    [XmlRoot("results")]
    public class AdministratorList : BaseApiBean
    {
        [XmlElement("administrators")]
        [XmlElement("administrator")]
        public List<Administrator>? Items { get; set; }

        public required PageInfo PageInfo { get; set; }

        public required PermissionInfo PermissionInfo { get; set; }

        // Path("administrator")
        [XmlRoot("results")]
        public class AdministratorListList : BaseApiListBean<AdministratorList>
        {
            public override List<AdministratorList>? GetItems() => Items;

            public override void SetItems(List<AdministratorList>? value) => Items = value;
        }
    }
}