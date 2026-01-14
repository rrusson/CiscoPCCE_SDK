using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("externalpage")
    [XmlRoot("results")]
    public class ExternalPageList : BaseApiWrappedList<ExternalPage>
    {
        [XmlArray("externalpages")]
        [XmlArrayItem("externalpage")]
        public new List<ExternalPage>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}