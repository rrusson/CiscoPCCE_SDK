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


@Path("smartlicense")
@XmlRootElement(name="results")
public class SmartLicenseEntitlementList extends BaseApiBean {
  private List<SmartLicenseEntitlement> items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  @XmlElementWrapper(name="smartlicenseentitlements")
  @XmlElement(name="smartlicenseentitlement")
  public List<SmartLicenseEntitlement> getItems() {
     return this.items;
  }

  public void setItems(List<SmartLicenseEntitlement> items) {
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


  @Path("smartlicense")
  @XmlRootElement(name = "results")
  public static class SmartLicenseEntitlementListList extends BaseApiListBean<SmartLicenseEntitlementList> {
    @XmlElementWrapper(name = "resultss")
    @XmlElement(name = "results")
    public List<SmartLicenseEntitlementList> getItems() {
      return items;
    }

    public void setItems(List<SmartLicenseEntitlementList> items) {
      this.items = items;
    }
  }
}
