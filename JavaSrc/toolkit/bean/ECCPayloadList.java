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


@Path("/eccpayload")
@XmlRootElement(name="results")
public class ECCPayloadList extends BaseApiBean {
  private List<ECCPayload> items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  @XmlElementWrapper(name="eccpayloads")
  @XmlElement(name="eccpayload")
  public List<ECCPayload> getItems() {
     return this.items;
  }

  public void setItems(List<ECCPayload> items) {
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


  @Path("/eccpayload")
  @XmlRootElement(name = "results")
  public static class ECCPayloadListList extends BaseApiListBean<ECCPayloadList> {
    @XmlElementWrapper(name = "resultss")
    @XmlElement(name = "results")
    public List<ECCPayloadList> getItems() {
      return items;
    }

    public void setItems(List<ECCPayloadList> items) {
      this.items = items;
    }
  }
}
