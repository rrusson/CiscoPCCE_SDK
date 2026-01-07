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


@XmlRootElement(name="server")
public class CallServer extends BaseApiBean {
  private String address;
  private Integer messageBusNumber;
  private Integer port;
  private Integer subsystemNumber;

  public String getAddress() {
     return this.address;
  }

  public void setAddress(String address) {
     this.address = address;
  }

  public Integer getMessageBusNumber() {
     return this.messageBusNumber;
  }

  public void setMessageBusNumber(Integer messageBusNumber) {
     this.messageBusNumber = messageBusNumber;
  }

  public Integer getPort() {
     return this.port;
  }

  public void setPort(Integer port) {
     this.port = port;
  }

  public Integer getSubsystemNumber() {
     return this.subsystemNumber;
  }

  public void setSubsystemNumber(Integer subsystemNumber) {
     this.subsystemNumber = subsystemNumber;
  }


}
