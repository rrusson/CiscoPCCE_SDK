using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    public class DeploymentTaskInfo : BaseApiBean
    {
        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("passing")]
        public bool? Passing { get; set; }
    }
}