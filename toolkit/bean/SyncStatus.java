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


@XmlRootElement(name="syncStatus")
public class SyncStatus extends BaseApiBean {
  private String currentSyncStatus;
  private String lastSyncStats;
  private String lastSyncStatus;
  private String lastSyncTime;

  public String getCurrentSyncStatus() {
     return this.currentSyncStatus;
  }

  public void setCurrentSyncStatus(String currentSyncStatus) {
     this.currentSyncStatus = currentSyncStatus;
  }

  public String getLastSyncStats() {
     return this.lastSyncStats;
  }

  public void setLastSyncStats(String lastSyncStats) {
     this.lastSyncStats = lastSyncStats;
  }

  public String getLastSyncStatus() {
     return this.lastSyncStatus;
  }

  public void setLastSyncStatus(String lastSyncStatus) {
     this.lastSyncStatus = lastSyncStatus;
  }

  public String getLastSyncTime() {
     return this.lastSyncTime;
  }

  public void setLastSyncTime(String lastSyncTime) {
     this.lastSyncTime = lastSyncTime;
  }


}
