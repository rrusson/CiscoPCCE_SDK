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


@Path("externalpage")
@XmlRootElement(name="results")
public class ExternalPageList extends BaseApiBean {
  private List<ExternalPage> items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  @XmlElementWrapper(name="externalpages")
  @XmlElement(name="externalpage")
  public List<ExternalPage> getItems() {
     return this.items;
  }

  public void setItems(List<ExternalPage> items) {
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


  @Path("externalpage")
  @XmlRootElement(name = "results")
  public static class ExternalPageListList extends BaseApiListBean<ExternalPageList> {
    @XmlElementWrapper(name = "resultss")
    @XmlElement(name = "results")
    public List<ExternalPageList> getItems() {
      return items;
    }

    public void setItems(List<ExternalPageList> items) {
      this.items = items;
    }
  }
}
