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


@XmlRootElement(name="sipServerGroupElements")
public class SIPServerGroupElement extends BaseApiBean {
  private String elementName;
  private String port;
  private String priority;
  private String securePort;
  private String weight;

  public String getElementName() {
     return this.elementName;
  }

  public void setElementName(String elementName) {
     this.elementName = elementName;
  }

  public String getPort() {
     return this.port;
  }

  public void setPort(String port) {
     this.port = port;
  }

  public String getPriority() {
     return this.priority;
  }

  public void setPriority(String priority) {
     this.priority = priority;
  }

  public String getSecurePort() {
     return this.securePort;
  }

  public void setSecurePort(String securePort) {
     this.securePort = securePort;
  }

  public String getWeight() {
     return this.weight;
  }

  public void setWeight(String weight) {
     this.weight = weight;
  }


}
