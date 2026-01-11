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


@Path("applicationgateway")
@XmlRootElement(name="applicationGateway")
public class ApplicationGateway extends BaseApiBean {
  private String baseUrlfromRefUrl;
  private Integer changeStamp;
  private List<ApplicationGatewayConnection> connections;
  private String correlationId;
  private ReferenceBean department;
  private String description;
  private ApplicationGatewayEncryptionEnum encryption;
  private ApplicationGatewayFaultTolerance faultTolerance;
  private String idFromRefUrl;
  private String name;
  private ApplicationGatewayPreferredSide preferredSide;
  private String refURL;

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

  @XmlElementWrapper(name="connections")
  @XmlElement(name="connection")
  public List<ApplicationGatewayConnection> getConnections() {
     return this.connections;
  }

  public void setConnections(List<ApplicationGatewayConnection> connections) {
     this.connections = connections;
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

  public ApplicationGatewayEncryptionEnum getEncryption() {
     return this.encryption;
  }

  public void setEncryption(ApplicationGatewayEncryptionEnum encryption) {
     this.encryption = encryption;
  }

  public ApplicationGatewayFaultTolerance getFaultTolerance() {
     return this.faultTolerance;
  }

  public void setFaultTolerance(ApplicationGatewayFaultTolerance faultTolerance) {
     this.faultTolerance = faultTolerance;
  }

  public String getIdFromRefUrl() {
     return this.idFromRefUrl;
  }

  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  public String getName() {
     return this.name;
  }

  public void setName(String name) {
     this.name = name;
  }

  public ApplicationGatewayPreferredSide getPreferredSide() {
     return this.preferredSide;
  }

  public void setPreferredSide(ApplicationGatewayPreferredSide preferredSide) {
     this.preferredSide = preferredSide;
  }

  public String getRefURL() {
     return this.refURL;
  }

  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }


  @Path("applicationgateway")
  @XmlRootElement(name = "results")
  public static class ApplicationGatewayList extends BaseApiListBean<ApplicationGateway> {
    @XmlElementWrapper(name = "applicationGateways")
    @XmlElement(name = "applicationGateway")
    public List<ApplicationGateway> getItems() {
      return items;
    }

    public void setItems(List<ApplicationGateway> items) {
      this.items = items;
    }
  }
}
