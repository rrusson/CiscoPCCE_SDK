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


@XmlRootElement(name="reportingServer")
public class ReportingServer extends BaseApiBean {
  private String ip;
  private Integer messageBusNumber;

  public String getIp() {
     return this.ip;
  }

  public void setIp(String ip) {
     this.ip = ip;
  }

  public Integer getMessageBusNumber() {
     return this.messageBusNumber;
  }

  public void setMessageBusNumber(Integer messageBusNumber) {
     this.messageBusNumber = messageBusNumber;
  }


}
