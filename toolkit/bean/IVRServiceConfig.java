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


@XmlRootElement(name="ivr")
public class IVRServiceConfig extends BaseApiBean {
  private Integer callTimeout;
  private Boolean useBackupMediaServers;
  private Boolean useMediaServerHostNames;
  private Boolean useSecurityForMediaFetches;

  public Integer getCallTimeout() {
     return this.callTimeout;
  }

  public void setCallTimeout(Integer callTimeout) {
     this.callTimeout = callTimeout;
  }

  public Boolean getUseBackupMediaServers() {
     return this.useBackupMediaServers;
  }

  public void setUseBackupMediaServers(Boolean useBackupMediaServers) {
     this.useBackupMediaServers = useBackupMediaServers;
  }

  public Boolean getUseMediaServerHostNames() {
     return this.useMediaServerHostNames;
  }

  public void setUseMediaServerHostNames(Boolean useMediaServerHostNames) {
     this.useMediaServerHostNames = useMediaServerHostNames;
  }

  public Boolean getUseSecurityForMediaFetches() {
     return this.useSecurityForMediaFetches;
  }

  public void setUseSecurityForMediaFetches(Boolean useSecurityForMediaFetches) {
     this.useSecurityForMediaFetches = useSecurityForMediaFetches;
  }


}
