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


@Path("cloudconnectsettings")
@XmlRootElement(name="CloudConnectSettings")
public class CloudConnector extends BaseApiBean {
  private String baseUrlfromRefUrl;
  private Integer changeStamp;
  private String correlationId;
  private ReferenceBean department;
  private String deploymentID;
  private String deploymentName;
  private Integer id;
  private String idFromRefUrl;
  private String proxyAddress;
  private String refURL;
  private String registrationStatus;

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

  public String getDeploymentID() {
     return this.deploymentID;
  }

  public void setDeploymentID(String deploymentID) {
     this.deploymentID = deploymentID;
  }

  public String getDeploymentName() {
     return this.deploymentName;
  }

  public void setDeploymentName(String deploymentName) {
     this.deploymentName = deploymentName;
  }

  public Integer getId() {
     return this.id;
  }

  public void setId(Integer id) {
     this.id = id;
  }

  public String getIdFromRefUrl() {
     return this.idFromRefUrl;
  }

  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  public String getProxyAddress() {
     return this.proxyAddress;
  }

  public void setProxyAddress(String proxyAddress) {
     this.proxyAddress = proxyAddress;
  }

  public String getRefURL() {
     return this.refURL;
  }

  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public String getRegistrationStatus() {
     return this.registrationStatus;
  }

  public void setRegistrationStatus(String registrationStatus) {
     this.registrationStatus = registrationStatus;
  }


  @Path("cloudconnectsettings")
  @XmlRootElement(name = "results")
  public static class CloudConnectorList extends BaseApiListBean<CloudConnector> {
    @XmlElementWrapper(name = "CloudConnectSettingss")
    @XmlElement(name = "CloudConnectSettings")
    public List<CloudConnector> getItems() {
      return items;
    }

    public void setItems(List<CloudConnector> items) {
      this.items = items;
    }
  }
}
