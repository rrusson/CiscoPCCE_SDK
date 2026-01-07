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
public class SmartLicenseInfoList extends BaseApiBean {
  private List<SmartLicenseInfo> items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  @XmlElementWrapper(name="smartlicenseinfos")
  @XmlElement(name="smartlicenseinfo")
  public List<SmartLicenseInfo> getItems() {
     return this.items;
  }

  public void setItems(List<SmartLicenseInfo> items) {
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
  public static class SmartLicenseInfoListList extends BaseApiListBean<SmartLicenseInfoList> {
    @XmlElementWrapper(name = "resultss")
    @XmlElement(name = "results")
    public List<SmartLicenseInfoList> getItems() {
      return items;
    }

    public void setItems(List<SmartLicenseInfoList> items) {
      this.items = items;
    }
  }
}
