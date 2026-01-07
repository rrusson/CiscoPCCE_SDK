using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("##default")]
    public class AssociatedGroup : BaseApiBean
    {
        public string? GroupName { get; set; }

        public string? Id { get; set; }
    }
}