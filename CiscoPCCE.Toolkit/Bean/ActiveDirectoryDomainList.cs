using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("activedirectorydomain")
    [XmlRoot("results")]
    public class ActiveDirectoryDomainList : BaseApiList<ActiveDirectoryDomain>
    {
        [XmlArray("activeDirectoryDomains")]
        [XmlArrayItem("activeDirectoryDomain")]
        public new List<ActiveDirectoryDomain>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}