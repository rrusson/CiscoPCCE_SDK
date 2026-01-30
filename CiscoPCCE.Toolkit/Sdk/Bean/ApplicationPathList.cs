using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("applicationpath")
    [XmlRoot("results")]
    public class ApplicationPathList : BaseApiWrappedList<ApplicationPath>
    {
        [XmlArray("applicationPaths")]
        [XmlArrayItem("applicationPath")]
        public new List<ApplicationPath>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}