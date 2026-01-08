using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("operation")
    [XmlRoot("errorDetail")]
    public class ResourceErrorDetail : BaseApiBean
    {
        [XmlElement("apiErrors")]
        public required ApiErrors ApiErrors { get; set; }

        [XmlElement("changeSetElement")]
        public required ChangeSetElement ChangeSetElement { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        // Path("operation")
        [XmlRoot("results")]
        public class ResourceErrorDetailList : BaseApiListBean<ResourceErrorDetail>
        {
            [XmlArray("errorDetails")]
            [XmlArrayItem("errorDetail")]
            public new List<ResourceErrorDetail>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<ResourceErrorDetail>? GetItems() => Items;

            public override void SetItems(List<ResourceErrorDetail>? value) => Items = value;
        }
    }
}