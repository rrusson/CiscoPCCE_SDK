using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("contactcenterai/token")
    [XmlRoot("results")]
    public class ContactCenterAITokenList : BaseApiList<ContactCenterAIToken>
    {
        [XmlArray("contactCenterAITokens")]
        [XmlArrayItem("contactCenterAIToken")]
        public new List<ContactCenterAIToken>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}