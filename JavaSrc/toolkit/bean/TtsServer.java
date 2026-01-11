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


@XmlRootElement(name="ttsServer")
public class TtsServer extends BaseApiBean {
  private Integer port;
  private String ttsServerName;

  public Integer getPort() {
     return this.port;
  }

  public void setPort(Integer port) {
     this.port = port;
  }

  public String getTtsServerName() {
     return this.ttsServerName;
  }

  public void setTtsServerName(String ttsServerName) {
     this.ttsServerName = ttsServerName;
  }


}
