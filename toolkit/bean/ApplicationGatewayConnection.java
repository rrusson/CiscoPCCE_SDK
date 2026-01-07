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


public class ApplicationGatewayConnection extends BaseApiBean {
  private String address;
  private HeartBeat heartBeat;
  private Boolean inService;
  private String initializationData;
  private Integer maxErrors;
  private Integer port;
  private Session session;
  private ApplicationGatewayPreferredSide side;
  private Timeout timeout;

  public String getAddress() {
     return this.address;
  }

  public void setAddress(String address) {
     this.address = address;
  }

  public HeartBeat getHeartBeat() {
     return this.heartBeat;
  }

  public void setHeartBeat(HeartBeat heartBeat) {
     this.heartBeat = heartBeat;
  }

  public Boolean getInService() {
     return this.inService;
  }

  public void setInService(Boolean inService) {
     this.inService = inService;
  }

  public String getInitializationData() {
     return this.initializationData;
  }

  public void setInitializationData(String initializationData) {
     this.initializationData = initializationData;
  }

  public Integer getMaxErrors() {
     return this.maxErrors;
  }

  public void setMaxErrors(Integer maxErrors) {
     this.maxErrors = maxErrors;
  }

  public Integer getPort() {
     return this.port;
  }

  public void setPort(Integer port) {
     this.port = port;
  }

  public Session getSession() {
     return this.session;
  }

  public void setSession(Session session) {
     this.session = session;
  }

  public ApplicationGatewayPreferredSide getSide() {
     return this.side;
  }

  public void setSide(ApplicationGatewayPreferredSide side) {
     this.side = side;
  }

  public Timeout getTimeout() {
     return this.timeout;
  }

  public void setTimeout(Timeout timeout) {
     this.timeout = timeout;
  }


}
