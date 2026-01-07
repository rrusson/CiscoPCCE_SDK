using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("activedirectorydomain")
    [XmlRoot("results")]
    public class ActiveDirectoryDomainList : BaseApiBean
    {
        // Path("activedirectorydomain")
        [XmlRoot("results")]
        public class ActiveDirectoryDomainListList : BaseApiListBean<ActiveDirectoryDomainList>
        {
            public override List<ActiveDirectoryDomainList>? GetItems() => Items;

            public override void SetItems(List<ActiveDirectoryDomainList>? value) => Items = value;
        }
    }
}