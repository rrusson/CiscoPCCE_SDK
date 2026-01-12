using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
// Path("role")
[XmlRoot("results")]
public class InvalidFeaturesErrorDetailList : BaseApiList<InvalidFeaturesErrorDetail>
{
    [XmlArray("errorDetails")]
    [XmlArrayItem("errorDetail")]
    public new List<InvalidFeaturesErrorDetail>? Items
    {
        get => base.Items;
        set => base.Items = value;
    }
}
}
