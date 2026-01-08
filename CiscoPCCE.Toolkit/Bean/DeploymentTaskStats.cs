using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    public class DeploymentTaskStats : BaseApiBean
    {
        [XmlArray("deploymentTaskStats")]
        [XmlArrayItem("deploymentTaskInfo")]
        public List<DeploymentTaskInfo>? TaskStats { get; set; }
    }
}