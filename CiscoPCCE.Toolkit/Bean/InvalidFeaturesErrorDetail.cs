using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("role")
    [XmlRoot("errorDetail")]
    public class InvalidFeaturesErrorDetail : BaseApiBean
    {
        [XmlArray("invalidFeatures")]
        [XmlArrayItem("invalidFeature")]
        public List<Feature>? InvalidFeatures { get; set; }

        // Path("role")
        [XmlRoot("results")]
        public class InvalidFeaturesErrorDetailList : BaseApiListBean<InvalidFeaturesErrorDetail>
        {
            [XmlArray("errorDetails")]
            [XmlArrayItem("errorDetail")]
            public new List<InvalidFeaturesErrorDetail>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<InvalidFeaturesErrorDetail>? GetItems() => Items;

            public override void SetItems(List<InvalidFeaturesErrorDetail>? value) => Items = value;
        }
    }
}