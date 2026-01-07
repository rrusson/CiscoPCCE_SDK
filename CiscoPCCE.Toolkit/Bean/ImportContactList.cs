using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("results")]
    public class ImportContactList : BaseApiBean
    {
        [XmlElement("importContacts")]
        [XmlElement("importContact")]
        public List<ImportContactBase>? Items { get; set; }

        public required PageInfo PageInfo { get; set; }

        public required PermissionInfo PermissionInfo { get; set; }
    }
}