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


@Path("locationproperties")
@XmlRootElement(name="locationProperties")
public class LocationProperties extends BaseApiBean {
  private String locationRoutingCodeInsertOption;

  public String getLocationRoutingCodeInsertOption() {
     return this.locationRoutingCodeInsertOption;
  }

  public void setLocationRoutingCodeInsertOption(String locationRoutingCodeInsertOption) {
     this.locationRoutingCodeInsertOption = locationRoutingCodeInsertOption;
  }


  @Path("locationproperties")
  @XmlRootElement(name = "results")
  public static class LocationPropertiesList extends BaseApiListBean<LocationProperties> {
    @XmlElementWrapper(name = "locationPropertiess")
    @XmlElement(name = "locationProperties")
    public List<LocationProperties> getItems() {
      return items;
    }

    public void setItems(List<LocationProperties> items) {
      this.items = items;
    }
  }
}
