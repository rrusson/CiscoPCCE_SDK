using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("errorDetail")]
    public class InvalidFeaturesErrorDetail : BaseApiBean
    {
        [XmlArray("invalidFeatures")]
        [XmlArrayItem("invalidFeature")]
        public List<Feature>? InvalidFeatures { get; set; }
    }
}