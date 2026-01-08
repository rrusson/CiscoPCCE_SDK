using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("externalpage")
    [XmlRoot("results")]
    public class ExternalPageList : BaseApiBean
    {
        [XmlArray("externalpages")]
        [XmlArrayItem("externalpage")]
        public List<ExternalPage>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }

        // Path("externalpage")
        [XmlRoot("results")]
        public class ExternalPageListList : BaseApiListBean<ExternalPageList>
        {
            public override List<ExternalPageList>? GetItems() => Items;

            public override void SetItems(List<ExternalPageList>? value) => Items = value;
        }
    }
}