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


@Path("applicationgatewayglobalsetting")
@XmlRootElement(name="results")
public class ApplicationGatewayGlobalsList extends BaseApiBean {
  private List<ApplicationGatewayGlobals> items;
  private PermissionInfo permissionInfo;

  @XmlElementWrapper(name="applicationGatewayGlobalSettings")
  @XmlElement(name="applicationGatewayGlobalSetting")
  public List<ApplicationGatewayGlobals> getItems() {
     return this.items;
  }

  public void setItems(List<ApplicationGatewayGlobals> items) {
     this.items = items;
  }

  public PermissionInfo getPermissionInfo() {
     return this.permissionInfo;
  }

  public void setPermissionInfo(PermissionInfo permissionInfo) {
     this.permissionInfo = permissionInfo;
  }


  @Path("applicationgatewayglobalsetting")
  @XmlRootElement(name = "results")
  public static class ApplicationGatewayGlobalsListList extends BaseApiListBean<ApplicationGatewayGlobalsList> {
    @XmlElementWrapper(name = "resultss")
    @XmlElement(name = "results")
    public List<ApplicationGatewayGlobalsList> getItems() {
      return items;
    }

    public void setItems(List<ApplicationGatewayGlobalsList> items) {
      this.items = items;
    }
  }
}
