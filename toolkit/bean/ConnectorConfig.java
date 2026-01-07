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


public class ConnectorConfig extends BaseApiBean {
  private boolean proxyEnabled;
  private String proxyHost;
  private String proxyPort;

  public boolean getProxyEnabled() {
     return this.proxyEnabled;
  }

  public void setProxyEnabled(boolean proxyEnabled) {
     this.proxyEnabled = proxyEnabled;
  }

  public String getProxyHost() {
     return this.proxyHost;
  }

  public void setProxyHost(String proxyHost) {
     this.proxyHost = proxyHost;
  }

  public String getProxyPort() {
     return this.proxyPort;
  }

  public void setProxyPort(String proxyPort) {
     this.proxyPort = proxyPort;
  }


}
