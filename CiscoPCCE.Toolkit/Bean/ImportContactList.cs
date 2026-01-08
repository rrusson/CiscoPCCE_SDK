using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("results")]
    public class ImportContactList : BaseApiBean
    {
        [XmlArray("importContacts")]
        [XmlArrayItem("importContact")]
        public List<ImportContactBase>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }
    }
}