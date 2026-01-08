using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("configurabledeviceinfo")
    [XmlRoot("configurableDevices")]
    public class ConfigurableDeviceInfo : BaseApiBean
    {
        [XmlArray("deviceTypes")]
        [XmlArrayItem("deviceType")]
        public List<DeviceInfo>? DeviceInfo { get; set; }

        // Path("configurabledeviceinfo")
        [XmlRoot("results")]
        public class ConfigurableDeviceInfoList : BaseApiListBean<ConfigurableDeviceInfo>
        {
            public override List<ConfigurableDeviceInfo>? GetItems() => Items;

            public override void SetItems(List<ConfigurableDeviceInfo>? value) => Items = value;
        }
    }
}