using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("configurabledeviceinfo")
[XmlRoot("configurableDevices")]
public class ConfigurableDeviceInfo : BaseApiBean {
  private List<DeviceInfo>? deviceInfo;

  [XmlElement("deviceTypes")]
  [XmlElement("deviceType")]
  public List<DeviceInfo>? DeviceInfo
  {
      get => deviceInfo;
      set => deviceInfo = value;
  }


  public void setDeviceInfo(List<DeviceInfo> deviceInfo) {
     this.deviceInfo = deviceInfo;
  }


  // Path("configurabledeviceinfo")
  [XmlRoot("results")]
  public class ConfigurableDeviceInfoList : BaseApiListBean<ConfigurableDeviceInfo> {
    [XmlElement("configurableDevicess")]
    [XmlElement("configurableDevices")]
   
    public override List<ConfigurableDeviceInfo>? GetItems() => items;

    public override void SetItems(List<ConfigurableDeviceInfo>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<ConfigurableDeviceInfo>? items)
    {
        this.items = items;
    }
  }
}

}