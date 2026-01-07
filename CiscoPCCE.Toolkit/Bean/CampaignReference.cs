using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("reference")]
    public class CampaignReference : BaseApiBean
    {
        public bool? Deleted { get; set; }

        public int? Id { get; set; }

        public string? Name { get; set; }
    }
}