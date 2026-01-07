using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("errorDetail")]
    public class ADNameUsedApiErrorDetail : BaseApiBean
    {
        public string? Name { get; set; }

        public new string? RefURL { get; set; }

        public string? ReferenceType { get; set; }
    }
}