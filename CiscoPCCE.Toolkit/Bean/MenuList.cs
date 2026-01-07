using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("results")]
    public class MenuList : BaseApiBean
    {
        [XmlElement("menus")]
        [XmlElement("menu")]
        public List<Menu>? Items { get; set; }

        public required PageInfo PageInfo { get; set; }

        public required PermissionInfo PermissionInfo { get; set; }
    }
}