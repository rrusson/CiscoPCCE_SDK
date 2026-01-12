using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("administrator")
    [XmlRoot("results")]
    public class AdministratorList : BaseApiList<Administrator>
    {
        [XmlArray("administrators")]
        [XmlArrayItem("administrator")]
        public new List<Administrator>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }
    }
}