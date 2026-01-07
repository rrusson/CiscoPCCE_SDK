using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("activedirectorydomain")
    [XmlRoot("activeDirectoryDomain")]
    public class ActiveDirectoryDomain : BaseApiBean
    {
        public string? Name { get; set; }

        public bool? SystemDomain { get; set; }

        // Path("activedirectorydomain")
        [XmlRoot("results")]
        public class ActiveDirectoryDomainList : BaseApiListBean<ActiveDirectoryDomain>
        {
            public override List<ActiveDirectoryDomain>? GetItems() => Items;

            public override void SetItems(List<ActiveDirectoryDomain>? value) => Items = value;
        }
    }
}