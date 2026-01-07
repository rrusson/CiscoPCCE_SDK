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


@XmlRootElement(name="syncConfig")
public class SyncConfigBean extends BaseApiBean {
  private Boolean enabled;
  private String endTime;
  private Integer frequency;
  private List<String> groups;
  private String startTime;

  public Boolean getEnabled() {
     return this.enabled;
  }

  public void setEnabled(Boolean enabled) {
     this.enabled = enabled;
  }

  public String getEndTime() {
     return this.endTime;
  }

  public void setEndTime(String endTime) {
     this.endTime = endTime;
  }

  public Integer getFrequency() {
     return this.frequency;
  }

  public void setFrequency(Integer frequency) {
     this.frequency = frequency;
  }

  @XmlElementWrapper(name="groups")
  @XmlElement(name="group")
  public List<String> getGroups() {
     return this.groups;
  }

  public void setGroups(List<String> groups) {
     this.groups = groups;
  }

  public String getStartTime() {
     return this.startTime;
  }

  public void setStartTime(String startTime) {
     this.startTime = startTime;
  }


}
