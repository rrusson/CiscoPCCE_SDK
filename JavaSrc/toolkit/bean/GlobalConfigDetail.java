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


@Path("contactcenterai")
@XmlRootElement(name="globalConfigDetail")
public class GlobalConfigDetail extends BaseApiBean {
  private List<GlobalConfig> globalConfigs;
  private Date lastSyncTime;
  private Date nextAutoSyncTime;
  private Status status;

  @XmlElementWrapper(name="globalConfigs")
  @XmlElement(name="globalConfig")
  public List<GlobalConfig> getGlobalConfigs() {
     return this.globalConfigs;
  }

  public void setGlobalConfigs(List<GlobalConfig> globalConfigs) {
     this.globalConfigs = globalConfigs;
  }

  public Date getLastSyncTime() {
     return this.lastSyncTime;
  }

  public void setLastSyncTime(Date lastSyncTime) {
     this.lastSyncTime = lastSyncTime;
  }

  public Date getNextAutoSyncTime() {
     return this.nextAutoSyncTime;
  }

  public void setNextAutoSyncTime(Date nextAutoSyncTime) {
     this.nextAutoSyncTime = nextAutoSyncTime;
  }

  public Status getStatus() {
     return this.status;
  }

  public void setStatus(Status status) {
     this.status = status;
  }


  @Path("contactcenterai")
  @XmlRootElement(name = "results")
  public static class GlobalConfigDetailList extends BaseApiListBean<GlobalConfigDetail> {
    @XmlElementWrapper(name = "globalConfigDetails")
    @XmlElement(name = "globalConfigDetail")
    public List<GlobalConfigDetail> getItems() {
      return items;
    }

    public void setItems(List<GlobalConfigDetail> items) {
      this.items = items;
    }
  }
}
