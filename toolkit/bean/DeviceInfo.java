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


public class DeviceInfo extends BaseApiBean {
  private List<String> locations;
  private String typeName;

  @XmlElementWrapper(name="locations")
  @XmlElement(name="location")
  public List<String> getLocations() {
     return this.locations;
  }

  public void setLocations(List<String> locations) {
     this.locations = locations;
  }

  public String getTypeName() {
     return this.typeName;
  }

  public void setTypeName(String typeName) {
     this.typeName = typeName;
  }


}
