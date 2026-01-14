using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("businesshour")
    [XmlRoot("results")]
    public class BusinessHourConfiguredStatusList : BaseApiList<BusinessHourConfiguredStatus>
    {
        [XmlArray("configuredStatuss")]
        [XmlArrayItem("configuredStatus")]
        public new List<BusinessHourConfiguredStatus>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}