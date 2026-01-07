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


@Path("transferablefiles")
@XmlRootElement(name="results")
public class IVRApplicationList extends BaseApiBean {
  private List<IVRApplication> items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  @XmlElementWrapper(name="ivrapplications")
  @XmlElement(name="ivrapplication")
  public List<IVRApplication> getItems() {
     return this.items;
  }

  public void setItems(List<IVRApplication> items) {
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


  @Path("transferablefiles")
  @XmlRootElement(name = "results")
  public static class IVRApplicationListList extends BaseApiListBean<IVRApplicationList> {
    @XmlElementWrapper(name = "resultss")
    @XmlElement(name = "results")
    public List<IVRApplicationList> getItems() {
      return items;
    }

    public void setItems(List<IVRApplicationList> items) {
      this.items = items;
    }
  }
}
