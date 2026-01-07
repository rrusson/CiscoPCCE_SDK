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


public class ConnectionParametersGlobal extends BaseApiBean {
  private HeartBeat heartBeat;
  private Integer maxErrors;
  private Session session;
  private Timeout timeout;

  public HeartBeat getHeartBeat() {
     return this.heartBeat;
  }

  public void setHeartBeat(HeartBeat heartBeat) {
     this.heartBeat = heartBeat;
  }

  public Integer getMaxErrors() {
     return this.maxErrors;
  }

  public void setMaxErrors(Integer maxErrors) {
     this.maxErrors = maxErrors;
  }

  public Session getSession() {
     return this.session;
  }

  public void setSession(Session session) {
     this.session = session;
  }

  public Timeout getTimeout() {
     return this.timeout;
  }

  public void setTimeout(Timeout timeout) {
     this.timeout = timeout;
  }


}
