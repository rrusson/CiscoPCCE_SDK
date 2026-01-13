using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("deploymenttypeinfo")
    [XmlRoot("results")]
    public class DeploymentTypeInfoList : BaseApiList<DeploymentTypeInfo>
    {
        [XmlArray("deploymentTypeInfos")]
        [XmlArrayItem("deploymentTypeInfo")]
        public new List<DeploymentTypeInfo>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}