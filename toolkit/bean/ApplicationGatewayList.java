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


@Path("applicationgateway")
@XmlRootElement(name="results")
public class ApplicationGatewayList extends BaseApiBean {
  private List<ApplicationGateway> items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  @XmlElementWrapper(name="applicationGateways")
  @XmlElement(name="applicationGateway")
  public List<ApplicationGateway> getItems() {
     return this.items;
  }

  public void setItems(List<ApplicationGateway> items) {
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


  @Path("applicationgateway")
  @XmlRootElement(name = "results")
  public static class ApplicationGatewayListList extends BaseApiListBean<ApplicationGatewayList> {
    @XmlElementWrapper(name = "resultss")
    @XmlElement(name = "results")
    public List<ApplicationGatewayList> getItems() {
      return items;
    }

    public void setItems(List<ApplicationGatewayList> items) {
      this.items = items;
    }
  }
}
