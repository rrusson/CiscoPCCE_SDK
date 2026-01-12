using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
// Path("contactsharerule")
[XmlRoot("results")]
public class ContactShareExpressionErrorDetailList : BaseApiList<ContactShareExpressionErrorDetail>
{
    [XmlArray("errorDetails")]
    [XmlArrayItem("errorDetail")]
    public new List<ContactShareExpressionErrorDetail>? Items
    {
        get => base.Items;
        set => base.Items = value;
    }
}
}
