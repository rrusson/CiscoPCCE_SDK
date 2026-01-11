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


@Path("useridentity")
@XmlRootElement(name="userIdentity")
public class UserIdentity extends BaseApiBean {
  private String displayName;
  private String firstName;
  private String lastName;
  private String role;
  private String username;

  public String getDisplayName() {
     return this.displayName;
  }

  public void setDisplayName(String displayName) {
     this.displayName = displayName;
  }

  public String getFirstName() {
     return this.firstName;
  }

  public void setFirstName(String firstName) {
     this.firstName = firstName;
  }

  public String getLastName() {
     return this.lastName;
  }

  public void setLastName(String lastName) {
     this.lastName = lastName;
  }

  public String getRole() {
     return this.role;
  }

  public void setRole(String role) {
     this.role = role;
  }

  public String getUsername() {
     return this.username;
  }

  public void setUsername(String username) {
     this.username = username;
  }


  @Path("useridentity")
  @XmlRootElement(name = "results")
  public static class UserIdentityList extends BaseApiListBean<UserIdentity> {
    @XmlElementWrapper(name = "userIdentitys")
    @XmlElement(name = "userIdentity")
    public List<UserIdentity> getItems() {
      return items;
    }

    public void setItems(List<UserIdentity> items) {
      this.items = items;
    }
  }
}
