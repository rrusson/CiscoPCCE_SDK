using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    public class DeploymentTaskStats : BaseApiBean
    {
        [XmlArray("deploymentTaskStats")]
        [XmlArrayItem("deploymentTaskInfo")]
        public List<DeploymentTaskInfo>? TaskStats { get; set; }
    }
}