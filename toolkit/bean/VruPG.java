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


public class VruPG extends BaseApiBean {
  private Boolean configured;
  private String cvp1Address;
  private String cvp1Password;
  private String cvp1Username;
  private String cvp2Address;
  private String cvp2Password;
  private String cvp2Username;

  @XmlElement(name="configured")
  public Boolean getConfigured() {
     return this.configured;
  }

  public void setConfigured(Boolean configured) {
     this.configured = configured;
  }

  public String getCvp1Address() {
     return this.cvp1Address;
  }

  public void setCvp1Address(String cvp1Address) {
     this.cvp1Address = cvp1Address;
  }

  public String getCvp1Password() {
     return this.cvp1Password;
  }

  public void setCvp1Password(String cvp1Password) {
     this.cvp1Password = cvp1Password;
  }

  public String getCvp1Username() {
     return this.cvp1Username;
  }

  public void setCvp1Username(String cvp1Username) {
     this.cvp1Username = cvp1Username;
  }

  public String getCvp2Address() {
     return this.cvp2Address;
  }

  public void setCvp2Address(String cvp2Address) {
     this.cvp2Address = cvp2Address;
  }

  public String getCvp2Password() {
     return this.cvp2Password;
  }

  public void setCvp2Password(String cvp2Password) {
     this.cvp2Password = cvp2Password;
  }

  public String getCvp2Username() {
     return this.cvp2Username;
  }

  public void setCvp2Username(String cvp2Username) {
     this.cvp2Username = cvp2Username;
  }


}
