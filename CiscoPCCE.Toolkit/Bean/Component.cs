using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    public class Component : BaseApiBean
    {
        public TraceLevelEnum Level { get; set; }

        [XmlElement("traceMachines")]
        [XmlElement("traceMachine")]
        public List<TraceMachine>? TraceMachines { get; set; }

        public ProductEnum Type { get; set; }
    }
}