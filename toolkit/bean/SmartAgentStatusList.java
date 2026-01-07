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


@XmlRootElement(name="smartAgentStatusList")
public class SmartAgentStatusList extends BaseApiBean {
  private List<SmartAgentStatus> smartAgentStatuses;

  @XmlElement(name="smartAgentStatus")
  public List<SmartAgentStatus> getSmartAgentStatuses() {
     return this.smartAgentStatuses;
  }

  public void setSmartAgentStatuses(List<SmartAgentStatus> smartAgentStatuses) {
     this.smartAgentStatuses = smartAgentStatuses;
  }


}
