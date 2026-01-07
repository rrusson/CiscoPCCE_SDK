using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("results")]
    public class CardList : BaseApiBean
    {
        [XmlElement("cards")]
        [XmlElement("card")]
        public List<Card>? Items { get; set; }

        public required PageInfo PageInfo { get; set; }

        public required PermissionInfo PermissionInfo { get; set; }
    }
}