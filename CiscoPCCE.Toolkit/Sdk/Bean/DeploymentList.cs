using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("deployment")
    [XmlRoot("results")]
    public class DeploymentList : BaseApiList<Deployment>
    {
        [XmlArray("deployments")]
        [XmlArrayItem("deployment")]
        public new List<Deployment>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}