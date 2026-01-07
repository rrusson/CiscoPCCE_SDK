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


public class CloudConnectMgmtConfig extends BaseApiBean {
  private ConnectorConfig connCfg;
  private Long lastUpdatedTimestamp;

  public ConnectorConfig getConnCfg() {
     return this.connCfg;
  }

  public void setConnCfg(ConnectorConfig connCfg) {
     this.connCfg = connCfg;
  }

  public Long getLastUpdatedTimestamp() {
     return this.lastUpdatedTimestamp;
  }

  public void setLastUpdatedTimestamp(Long lastUpdatedTimestamp) {
     this.lastUpdatedTimestamp = lastUpdatedTimestamp;
  }


}
