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


public class Security extends BaseApiBean {
  private Boolean allowMixedMode;
  private Ciphers ciphers;
  private Boolean sipTLSEnabled;
  private Boolean srtp;
  private String tlsVersion;

  public Boolean getAllowMixedMode() {
     return this.allowMixedMode;
  }

  public void setAllowMixedMode(Boolean allowMixedMode) {
     this.allowMixedMode = allowMixedMode;
  }

  public Ciphers getCiphers() {
     return this.ciphers;
  }

  public void setCiphers(Ciphers ciphers) {
     this.ciphers = ciphers;
  }

  public Boolean getSipTLSEnabled() {
     return this.sipTLSEnabled;
  }

  public void setSipTLSEnabled(Boolean sipTLSEnabled) {
     this.sipTLSEnabled = sipTLSEnabled;
  }

  public Boolean getSrtp() {
     return this.srtp;
  }

  public void setSrtp(Boolean srtp) {
     this.srtp = srtp;
  }

  public String getTlsVersion() {
     return this.tlsVersion;
  }

  public void setTlsVersion(String tlsVersion) {
     this.tlsVersion = tlsVersion;
  }


}
