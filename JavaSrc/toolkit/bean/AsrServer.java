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


@XmlRootElement(name="asrServer")
public class AsrServer extends BaseApiBean {
  private Integer asrServerId;
  private String asrServerName;
  private Locales locales;
  private int portNumber;
  private String providerName;
  private String self;
  private String status;

  public Integer getAsrServerId() {
     return this.asrServerId;
  }

  public void setAsrServerId(Integer asrServerId) {
     this.asrServerId = asrServerId;
  }

  public String getAsrServerName() {
     return this.asrServerName;
  }

  public void setAsrServerName(String asrServerName) {
     this.asrServerName = asrServerName;
  }

  public Locales getLocales() {
     return this.locales;
  }

  public void setLocales(Locales locales) {
     this.locales = locales;
  }

  public int getPortNumber() {
     return this.portNumber;
  }

  public void setPortNumber(int portNumber) {
     this.portNumber = portNumber;
  }

  public String getProviderName() {
     return this.providerName;
  }

  public void setProviderName(String providerName) {
     this.providerName = providerName;
  }

  public String getSelf() {
     return this.self;
  }

  public void setSelf(String self) {
     this.self = self;
  }

  public String getStatus() {
     return this.status;
  }

  public void setStatus(String status) {
     this.status = status;
  }


}
