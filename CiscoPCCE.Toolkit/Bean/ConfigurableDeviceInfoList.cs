using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("configurabledeviceinfo")
    [XmlRoot("results")]
    public class ConfigurableDeviceInfoList : BaseApiList<ConfigurableDeviceInfo>
    {
        [XmlArray("configurableDevicess")]
        [XmlArrayItem("configurableDevices")]
        public new List<ConfigurableDeviceInfo>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}