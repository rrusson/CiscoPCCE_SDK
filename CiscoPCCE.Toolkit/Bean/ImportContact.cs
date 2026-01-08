using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("import")]
    public class ImportContact : BaseApiBean
    {
        [XmlElement("delimiter")]
        public string? Delimiter { get; set; }

        [XmlElement("fileContent")]
        public string? FileContent { get; set; }

        [XmlElement("overwriteData")]
        public bool? OverwriteData { get; set; }
    }
}