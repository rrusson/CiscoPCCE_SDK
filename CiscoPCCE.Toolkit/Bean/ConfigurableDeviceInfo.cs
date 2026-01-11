using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

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
            [XmlArray("configurableDevicess")]
            [XmlArrayItem("configurableDevices")]
            public new List<ConfigurableDeviceInfo>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<ConfigurableDeviceInfo>? GetItems() => Items;

            public override void SetItems(List<ConfigurableDeviceInfo>? value) => Items = value;
        }
    }
}