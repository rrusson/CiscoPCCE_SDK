using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    public class Component : BaseApiBean
    {
        [XmlElement("level")]
        public TraceLevelEnum Level { get; set; }

        [XmlArray("traceMachines")]
        [XmlArrayItem("traceMachine")]
        public List<TraceMachine>? TraceMachines { get; set; }

        [XmlElement("type")]
        public ProductEnum Type { get; set; }
    }
}