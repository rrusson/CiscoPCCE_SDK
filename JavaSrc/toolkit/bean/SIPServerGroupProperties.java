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


@Path("sipservergroupproperties")
@XmlRootElement(name="sipServerGroupProperties")
public class SIPServerGroupProperties extends BaseApiBean {
  private String optionsOverrideHost;
  private Integer serverGroupDownInterval;
  private Integer serverGroupHBLocalListenPort;
  private String serverGroupHBMethod;
  private Integer serverGroupHBNumTries;
  private Integer serverGroupHBTimeout;
  private String serverGroupHBTransportType;
  private Boolean serverGroupHeartbeats;
  private String serverGroupOverloadedResponseCodes;
  private Integer serverGroupUpInterval;

  public String getOptionsOverrideHost() {
     return this.optionsOverrideHost;
  }

  public void setOptionsOverrideHost(String optionsOverrideHost) {
     this.optionsOverrideHost = optionsOverrideHost;
  }

  public Integer getServerGroupDownInterval() {
     return this.serverGroupDownInterval;
  }

  public void setServerGroupDownInterval(Integer serverGroupDownInterval) {
     this.serverGroupDownInterval = serverGroupDownInterval;
  }

  public Integer getServerGroupHBLocalListenPort() {
     return this.serverGroupHBLocalListenPort;
  }

  public void setServerGroupHBLocalListenPort(Integer serverGroupHBLocalListenPort) {
     this.serverGroupHBLocalListenPort = serverGroupHBLocalListenPort;
  }

  public String getServerGroupHBMethod() {
     return this.serverGroupHBMethod;
  }

  public void setServerGroupHBMethod(String serverGroupHBMethod) {
     this.serverGroupHBMethod = serverGroupHBMethod;
  }

  public Integer getServerGroupHBNumTries() {
     return this.serverGroupHBNumTries;
  }

  public void setServerGroupHBNumTries(Integer serverGroupHBNumTries) {
     this.serverGroupHBNumTries = serverGroupHBNumTries;
  }

  public Integer getServerGroupHBTimeout() {
     return this.serverGroupHBTimeout;
  }

  public void setServerGroupHBTimeout(Integer serverGroupHBTimeout) {
     this.serverGroupHBTimeout = serverGroupHBTimeout;
  }

  public String getServerGroupHBTransportType() {
     return this.serverGroupHBTransportType;
  }

  public void setServerGroupHBTransportType(String serverGroupHBTransportType) {
     this.serverGroupHBTransportType = serverGroupHBTransportType;
  }

  public Boolean getServerGroupHeartbeats() {
     return this.serverGroupHeartbeats;
  }

  public void setServerGroupHeartbeats(Boolean serverGroupHeartbeats) {
     this.serverGroupHeartbeats = serverGroupHeartbeats;
  }

  public String getServerGroupOverloadedResponseCodes() {
     return this.serverGroupOverloadedResponseCodes;
  }

  public void setServerGroupOverloadedResponseCodes(String serverGroupOverloadedResponseCodes) {
     this.serverGroupOverloadedResponseCodes = serverGroupOverloadedResponseCodes;
  }

  public Integer getServerGroupUpInterval() {
     return this.serverGroupUpInterval;
  }

  public void setServerGroupUpInterval(Integer serverGroupUpInterval) {
     this.serverGroupUpInterval = serverGroupUpInterval;
  }


  @Path("sipservergroupproperties")
  @XmlRootElement(name = "results")
  public static class SIPServerGroupPropertiesList extends BaseApiListBean<SIPServerGroupProperties> {
    @XmlElementWrapper(name = "sipServerGroupPropertiess")
    @XmlElement(name = "sipServerGroupProperties")
    public List<SIPServerGroupProperties> getItems() {
      return items;
    }

    public void setItems(List<SIPServerGroupProperties> items) {
      this.items = items;
    }
  }
}
