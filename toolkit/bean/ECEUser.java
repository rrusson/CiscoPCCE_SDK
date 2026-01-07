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


@XmlRootElement(name="user")
public class ECEUser extends BaseApiBean {
  private ECEDepartment department;
  private Integer externalId;
  private String firstName;
  private Integer id;
  private String lastName;
  private String loginId;
  private String password;
  private String screenName;

  public ECEDepartment getDepartment() {
     return this.department;
  }

  public void setDepartment(ECEDepartment department) {
     this.department = department;
  }

  public Integer getExternalId() {
     return this.externalId;
  }

  public void setExternalId(Integer externalId) {
     this.externalId = externalId;
  }

  public String getFirstName() {
     return this.firstName;
  }

  public void setFirstName(String firstName) {
     this.firstName = firstName;
  }

  public Integer getId() {
     return this.id;
  }

  public void setId(Integer id) {
     this.id = id;
  }

  public String getLastName() {
     return this.lastName;
  }

  public void setLastName(String lastName) {
     this.lastName = lastName;
  }

  public String getLoginId() {
     return this.loginId;
  }

  public void setLoginId(String loginId) {
     this.loginId = loginId;
  }

  public String getPassword() {
     return this.password;
  }

  public void setPassword(String password) {
     this.password = password;
  }

  public String getScreenName() {
     return this.screenName;
  }

  public void setScreenName(String screenName) {
     this.screenName = screenName;
  }


}
