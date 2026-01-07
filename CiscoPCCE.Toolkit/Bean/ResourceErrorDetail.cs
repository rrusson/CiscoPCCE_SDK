using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("operation")
    [XmlRoot("errorDetail")]
    public class ResourceErrorDetail : BaseApiBean
    {
        public required ApiErrors ApiErrors { get; set; }

        public required ChangeSetElement ChangeSetElement { get; set; }

        public new string? RefURL { get; set; }

        // Path("operation")
        [XmlRoot("results")]
        public class ResourceErrorDetailList : BaseApiListBean<ResourceErrorDetail>
        {
            public override List<ResourceErrorDetail>? GetItems() => Items;

            public override void SetItems(List<ResourceErrorDetail>? value) => Items = value;
        }
    }
}