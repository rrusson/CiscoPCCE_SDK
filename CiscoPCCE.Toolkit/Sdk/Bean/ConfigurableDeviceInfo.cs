using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("configurableDevices")]
    public class ConfigurableDeviceInfo : BaseApiBean
    {
        [XmlArray("deviceTypes")]
        [XmlArrayItem("deviceType")]
        public List<DeviceInfo>? DeviceInfo { get; set; }
    }
}