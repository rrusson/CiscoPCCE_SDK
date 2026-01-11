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


public class ICMPostRouting extends BaseApiBean {
  private String defaultScript;
  private String initialScript;
  private int timeout;

  public String getDefaultScript() {
     return this.defaultScript;
  }

  public void setDefaultScript(String defaultScript) {
     this.defaultScript = defaultScript;
  }

  public String getInitialScript() {
     return this.initialScript;
  }

  public void setInitialScript(String initialScript) {
     this.initialScript = initialScript;
  }

  public int getTimeout() {
     return this.timeout;
  }

  public void setTimeout(int timeout) {
     this.timeout = timeout;
  }


}
