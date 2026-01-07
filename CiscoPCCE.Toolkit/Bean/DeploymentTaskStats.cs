using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    public class DeploymentTaskStats : BaseApiBean
    {
        [XmlElement("deploymentTaskStats")]
        [XmlElement("deploymentTaskInfo")]
        public List<DeploymentTaskInfo>? TaskStats { get; set; }
    }
}