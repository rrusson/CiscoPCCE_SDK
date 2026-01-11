using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("##default")]
    public class CUICBaseBean : BaseApiBean
    {
        [XmlElement("id")]
        public string? Id { get; set; }
    }
}