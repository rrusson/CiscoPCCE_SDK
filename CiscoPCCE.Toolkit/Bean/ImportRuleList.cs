using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("dnc")
    [XmlRoot("results")]
    public class ImportRuleList : BaseApiList<ImportRule>
    {
        [XmlArray("dncs")]
        [XmlArrayItem("dnc")]
        public new List<ImportRule>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}