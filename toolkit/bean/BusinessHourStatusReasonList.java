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


@Path("businesshourstatusreason")
@XmlRootElement(name="results")
public class BusinessHourStatusReasonList extends BaseApiBean {
  private List<BusinessHourStatusReason> items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  @XmlElementWrapper(name="businessHourStatusReasons")
  @XmlElement(name="businessHourStatusReason")
  public List<BusinessHourStatusReason> getItems() {
     return this.items;
  }

  public void setItems(List<BusinessHourStatusReason> items) {
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


  @Path("businesshourstatusreason")
  @XmlRootElement(name = "results")
  public static class BusinessHourStatusReasonListList extends BaseApiListBean<BusinessHourStatusReasonList> {
    @XmlElementWrapper(name = "resultss")
    @XmlElement(name = "results")
    public List<BusinessHourStatusReasonList> getItems() {
      return items;
    }

    public void setItems(List<BusinessHourStatusReasonList> items) {
      this.items = items;
    }
  }
}
