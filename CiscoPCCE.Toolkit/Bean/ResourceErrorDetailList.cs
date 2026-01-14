using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("operation")
    [XmlRoot("results")]
    public class ResourceErrorDetailList : BaseApiList<ResourceErrorDetail>
    {
        [XmlArray("errorDetails")]
        [XmlArrayItem("errorDetail")]
        public new List<ResourceErrorDetail>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}