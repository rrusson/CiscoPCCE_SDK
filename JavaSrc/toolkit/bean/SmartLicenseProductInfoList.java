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
public class SmartLicenseProductInfoList extends BaseApiBean {
  private List<SmartLicenseProductInfo> items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  @XmlElementWrapper(name="smartlicenseproductsinfo")
  @XmlElement(name="smartlicenseproductinfo")
  public List<SmartLicenseProductInfo> getItems() {
     return this.items;
  }

  public void setItems(List<SmartLicenseProductInfo> items) {
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
  public static class SmartLicenseProductInfoListList extends BaseApiListBean<SmartLicenseProductInfoList> {
    @XmlElementWrapper(name = "resultss")
    @XmlElement(name = "results")
    public List<SmartLicenseProductInfoList> getItems() {
      return items;
    }

    public void setItems(List<SmartLicenseProductInfoList> items) {
      this.items = items;
    }
  }
}
