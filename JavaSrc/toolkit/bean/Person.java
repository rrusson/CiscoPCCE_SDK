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


@Path("agent")
@XmlRootElement(name="person")
public class Person extends BaseApiBean {
  private String baseUrlfromRefUrl;
  private Integer changeStamp;
  private String correlationId;
  private ReferenceBean department;
  private String description;
  private Boolean digitalChannel;
  private Boolean ecePerson;
  private String emailAddress;
  private String firstName;
  private String idFromRefUrl;
  private String lastName;
  private Boolean loginEnabled;
  private Boolean markDeletable;
  private String password;
  private String refURL;
  private String screenName;
  private Boolean ssoEnabled;
  private String userName;

  public String getBaseUrlfromRefUrl() {
     return this.baseUrlfromRefUrl;
  }

  public void setBaseUrlfromRefUrl(String baseUrlfromRefUrl) {
     this.baseUrlfromRefUrl = baseUrlfromRefUrl;
  }

  public Integer getChangeStamp() {
     return this.changeStamp;
  }

  public void setChangeStamp(Integer changeStamp) {
     this.changeStamp = changeStamp;
  }

  public String getCorrelationId() {
     return this.correlationId;
  }

  public void setCorrelationId(String correlationId) {
     this.correlationId = correlationId;
  }

  public ReferenceBean getDepartment() {
     return this.department;
  }

  public void setDepartment(ReferenceBean department) {
     this.department = department;
  }

  public String getDescription() {
     return this.description;
  }

  public void setDescription(String description) {
     this.description = description;
  }

  public Boolean getDigitalChannel() {
     return this.digitalChannel;
  }

  public void setDigitalChannel(Boolean digitalChannel) {
     this.digitalChannel = digitalChannel;
  }

  public Boolean getEcePerson() {
     return this.ecePerson;
  }

  public void setEcePerson(Boolean ecePerson) {
     this.ecePerson = ecePerson;
  }

  public String getEmailAddress() {
     return this.emailAddress;
  }

  public void setEmailAddress(String emailAddress) {
     this.emailAddress = emailAddress;
  }

  public String getFirstName() {
     return this.firstName;
  }

  public void setFirstName(String firstName) {
     this.firstName = firstName;
  }

  public String getIdFromRefUrl() {
     return this.idFromRefUrl;
  }

  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  public String getLastName() {
     return this.lastName;
  }

  public void setLastName(String lastName) {
     this.lastName = lastName;
  }

  public Boolean getLoginEnabled() {
     return this.loginEnabled;
  }

  public void setLoginEnabled(Boolean loginEnabled) {
     this.loginEnabled = loginEnabled;
  }

  public Boolean getMarkDeletable() {
     return this.markDeletable;
  }

  public void setMarkDeletable(Boolean markDeletable) {
     this.markDeletable = markDeletable;
  }

  public String getPassword() {
     return this.password;
  }

  public void setPassword(String password) {
     this.password = password;
  }

  public String getRefURL() {
     return this.refURL;
  }

  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public String getScreenName() {
     return this.screenName;
  }

  public void setScreenName(String screenName) {
     this.screenName = screenName;
  }

  public Boolean getSsoEnabled() {
     return this.ssoEnabled;
  }

  public void setSsoEnabled(Boolean ssoEnabled) {
     this.ssoEnabled = ssoEnabled;
  }

  public String getUserName() {
     return this.userName;
  }

  public void setUserName(String userName) {
     this.userName = userName;
  }


  @Path("agent")
  @XmlRootElement(name = "results")
  public static class PersonList extends BaseApiListBean<Person> {
    @XmlElementWrapper(name = "persons")
    @XmlElement(name = "person")
    public List<Person> getItems() {
      return items;
    }

    public void setItems(List<Person> items) {
      this.items = items;
    }
  }
}
