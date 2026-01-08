using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("##default")]
    public class CUICBaseBean : BaseApiBean
    {
        [XmlElement("id")]
        public string? Id { get; set; }
    }
}