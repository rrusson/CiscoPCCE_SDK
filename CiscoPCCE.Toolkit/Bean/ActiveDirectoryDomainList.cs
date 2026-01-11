using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

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
            [XmlArray("resultss")]
            [XmlArrayItem("results")]
            public new List<ActiveDirectoryDomainList>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<ActiveDirectoryDomainList>? GetItems() => Items;

            public override void SetItems(List<ActiveDirectoryDomainList>? value) => Items = value;
        }
    }
}