using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("activedirectorydomain")
    [XmlRoot("activeDirectoryDomain")]
    public class ActiveDirectoryDomain : BaseApiBean
    {
        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("systemDomain")]
        public bool? SystemDomain { get; set; }

        // Path("activedirectorydomain")
        [XmlRoot("results")]
        public class ActiveDirectoryDomainList : BaseApiListBean<ActiveDirectoryDomain>
        {
            [XmlArray("activeDirectoryDomains")]
            [XmlArrayItem("activeDirectoryDomain")]
            public new List<ActiveDirectoryDomain>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<ActiveDirectoryDomain>? GetItems() => Items;

            public override void SetItems(List<ActiveDirectoryDomain>? value) => Items = value;
        }
    }
}