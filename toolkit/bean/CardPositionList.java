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


@Path("layout")
@XmlRootElement(name="layout")
public class CardPositionList extends BaseApiBean {
  private List<CardPosition> items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  @XmlElementWrapper(name="cards")
  @XmlElement(name="card")
  public List<CardPosition> getItems() {
     return this.items;
  }

  public void setItems(List<CardPosition> items) {
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


  @Path("layout")
  @XmlRootElement(name = "results")
  public static class CardPositionListList extends BaseApiListBean<CardPositionList> {
    @XmlElementWrapper(name = "layouts")
    @XmlElement(name = "layout")
    public List<CardPositionList> getItems() {
      return items;
    }

    public void setItems(List<CardPositionList> items) {
      this.items = items;
    }
  }
}
