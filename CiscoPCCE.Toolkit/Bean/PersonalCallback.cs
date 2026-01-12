using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("personalcallback")
    [XmlRoot("personalCallback")]
    public class PersonalCallback : BaseApiBean
    {
        [XmlElement("delimiter")]
        public string? Delimiter { get; set; }

        [XmlElement("fileContent")]
        public string? FileContent { get; set; }

        [XmlElement("overwriteData")]
        public bool? OverwriteData { get; set; }
        
    }
}