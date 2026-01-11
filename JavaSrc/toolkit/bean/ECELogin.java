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


@XmlRootElement(name="Login")
public class ECELogin extends BaseApiBean {
  private String password;
  private String userName;

  public String getPassword() {
     return this.password;
  }

  public void setPassword(String password) {
     this.password = password;
  }

  public String getUserName() {
     return this.userName;
  }

  public void setUserName(String userName) {
     this.userName = userName;
  }


}
