using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("errorDetail")]
    public class ValueListErrorDetail : BaseApiBean
    {
        [XmlArray("invalidValues")]
        [XmlArrayItem("invalidValue")]
        public List<string?>? InvalidValues { get; set; }
    }
}