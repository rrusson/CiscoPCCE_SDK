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


@XmlRootElement(name="OrgSettings")
public class OrgSettingsBean extends BaseApiBean {
  private String accessToken;
  private String idBrokerHost;
  private String idHost;
  private String orgID;

  public String getAccessToken() {
     return this.accessToken;
  }

  public void setAccessToken(String accessToken) {
     this.accessToken = accessToken;
  }

  public String getIdBrokerHost() {
     return this.idBrokerHost;
  }

  public void setIdBrokerHost(String idBrokerHost) {
     this.idBrokerHost = idBrokerHost;
  }

  public String getIdHost() {
     return this.idHost;
  }

  public void setIdHost(String idHost) {
     this.idHost = idHost;
  }

  public String getOrgID() {
     return this.orgID;
  }

  public void setOrgID(String orgID) {
     this.orgID = orgID;
  }


}
