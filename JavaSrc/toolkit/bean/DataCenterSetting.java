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


public class DataCenterSetting extends BaseApiBean {
  private AgentDataCenterSetting agent;
  private String baseUrl;
  private ReferenceBean datacenter;
  private NetworkLabelGlobalSetting labels;

  public AgentDataCenterSetting getAgent() {
     return this.agent;
  }

  public void setAgent(AgentDataCenterSetting agent) {
     this.agent = agent;
  }

  public String getBaseUrl() {
     return this.baseUrl;
  }

  public void setBaseUrl(String baseUrl) {
     this.baseUrl = baseUrl;
  }

  public ReferenceBean getDatacenter() {
     return this.datacenter;
  }

  public void setDatacenter(ReferenceBean datacenter) {
     this.datacenter = datacenter;
  }

  public NetworkLabelGlobalSetting getLabels() {
     return this.labels;
  }

  public void setLabels(NetworkLabelGlobalSetting labels) {
     this.labels = labels;
  }


}
