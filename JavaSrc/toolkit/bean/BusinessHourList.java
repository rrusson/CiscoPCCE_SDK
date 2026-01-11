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


@Path("businesshour")
@XmlRootElement(name="results")
public class BusinessHourList extends BaseApiBean {
  private List<BusinessHour> items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  @XmlElementWrapper(name="businessHours")
  @XmlElement(name="businessHour")
  public List<BusinessHour> getItems() {
     return this.items;
  }

  public void setItems(List<BusinessHour> items) {
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


  @Path("businesshour")
  @XmlRootElement(name = "results")
  public static class BusinessHourListList extends BaseApiListBean<BusinessHourList> {
    @XmlElementWrapper(name = "resultss")
    @XmlElement(name = "results")
    public List<BusinessHourList> getItems() {
      return items;
    }

    public void setItems(List<BusinessHourList> items) {
      this.items = items;
    }
  }
}
