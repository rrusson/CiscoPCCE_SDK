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


@Path("timezone")
@XmlRootElement(name="results")
public class TimeZoneLocationList extends BaseApiBean {
  private List<TimeZoneLocation> items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  @XmlElementWrapper(name="timeZones")
  @XmlElement(name="timeZone")
  public List<TimeZoneLocation> getItems() {
     return this.items;
  }

  public void setItems(List<TimeZoneLocation> items) {
     this.items = items;
  }

  public PageInfo getPageInfo() {
     return this.pageInfo;
  }

  public void setPageInfo(PageInfo pageInfo) {
     this.pageInfo = pageInfo;
  }

  public PermissionInfo getPermissionInfo() {
     return this.permissionInfo;
  }

  public void setPermissionInfo(PermissionInfo permissionInfo) {
     this.permissionInfo = permissionInfo;
  }


  @Path("timezone")
  @XmlRootElement(name = "results")
  public static class TimeZoneLocationListList extends BaseApiListBean<TimeZoneLocationList> {
    @XmlElementWrapper(name = "resultss")
    @XmlElement(name = "results")
    public List<TimeZoneLocationList> getItems() {
      return items;
    }

    public void setItems(List<TimeZoneLocationList> items) {
      this.items = items;
    }
  }
}
