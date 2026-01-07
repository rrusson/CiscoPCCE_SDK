// ----------------------------------------------
package com.cisco.ccbu.cce.unifiedconfig.toolkit.bean;

import com.cisco.ccbu.cce.unifiedconfig.toolkit.BaseApiBean;
import javax.xml.bind.annotation.XmlSeeAlso;
import javax.ws.rs.Path;
import javax.xml.bind.annotation.XmlRootElement;
import java.util.List;
import com.cisco.ccbu.cce.unifiedconfig.toolkit.ReferenceBean;
import java.util.Date;
import com.cisco.ccbu.cce.unifiedconfig.toolkit.BaseApiListBean;

import javax.xml.bind.annotation.XmlElement;

import javax.xml.bind.annotation.XmlElementWrapper;


@Path("configurabledeviceinfo")
@XmlRootElement(name="configurableDevices")
public class ConfigurableDeviceInfo extends BaseApiBean {
  private List<DeviceInfo> deviceInfo;

  @XmlElementWrapper(name="deviceTypes")
  @XmlElement(name="deviceType")
  public List<DeviceInfo> getDeviceInfo() {
     return this.deviceInfo;
  }

  public void setDeviceInfo(List<DeviceInfo> deviceInfo) {
     this.deviceInfo = deviceInfo;
  }


  @Path("configurabledeviceinfo")
  @XmlRootElement(name = "results")
  public static class ConfigurableDeviceInfoList extends BaseApiListBean<ConfigurableDeviceInfo> {
    @XmlElementWrapper(name = "configurableDevicess")
    @XmlElement(name = "configurableDevices")
    public List<ConfigurableDeviceInfo> getItems() {
      return items;
    }

    public void setItems(List<ConfigurableDeviceInfo> items) {
      this.items = items;
    }
  }
}
