using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("initStatus")]
    public class InitStatus : BaseApiBean
    {
        [XmlElement("state")]
        public StateEnum State { get; set; }

        [XmlElement("targetDeploymentType")]
        public DeploymentModel TargetDeploymentType { get; set; }
    }
}