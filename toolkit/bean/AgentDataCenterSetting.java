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


public class AgentDataCenterSetting extends BaseApiBean {
  private Integer agentPhoneLineControl;
  private String baseUrl;
  private ReferenceBean defaultDeskSetting;
  private Integer nonACDLineImpact;

  public Integer getAgentPhoneLineControl() {
     return this.agentPhoneLineControl;
  }

  public void setAgentPhoneLineControl(Integer agentPhoneLineControl) {
     this.agentPhoneLineControl = agentPhoneLineControl;
  }

  public String getBaseUrl() {
     return this.baseUrl;
  }

  public void setBaseUrl(String baseUrl) {
     this.baseUrl = baseUrl;
  }

  public ReferenceBean getDefaultDeskSetting() {
     return this.defaultDeskSetting;
  }

  public void setDefaultDeskSetting(ReferenceBean defaultDeskSetting) {
     this.defaultDeskSetting = defaultDeskSetting;
  }

  public Integer getNonACDLineImpact() {
     return this.nonACDLineImpact;
  }

  public void setNonACDLineImpact(Integer nonACDLineImpact) {
     this.nonACDLineImpact = nonACDLineImpact;
  }


}
