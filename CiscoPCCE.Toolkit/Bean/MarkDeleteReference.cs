using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("reference")]
    public class MarkDeleteReference : BaseApiBean
    {
        public bool? Deleted { get; set; }

        public string? Name { get; set; }

        public new string? RefURL { get; set; }
    }
}