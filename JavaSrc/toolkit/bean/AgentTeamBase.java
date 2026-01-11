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


@Path("/agentteam")
@XmlSeeAlso({AgentTeamSummary.class, AgentTeam.class})
public class AgentTeamBase extends BaseApiBean {
  private Integer agentCount;
  private String baseUrlfromRefUrl;
  private Integer changeStamp;
  private String correlationId;
  private ReferenceBean datacenter;
  private ReferenceBean department;
  private String description;
  private ReferenceBean dialedNumber;
  private String idFromRefUrl;
  private String name;
  private PeripheralRef peripheral;
  private Integer peripheralId;
  private ReferenceBean peripheralSet;
  private String refURL;
  private Integer supervisorCount;

  public Integer getAgentCount() {
     return this.agentCount;
  }

  public void setAgentCount(Integer agentCount) {
     this.agentCount = agentCount;
  }

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

  public ReferenceBean getDatacenter() {
     return this.datacenter;
  }

  public void setDatacenter(ReferenceBean datacenter) {
     this.datacenter = datacenter;
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

  public ReferenceBean getDialedNumber() {
     return this.dialedNumber;
  }

  public void setDialedNumber(ReferenceBean dialedNumber) {
     this.dialedNumber = dialedNumber;
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

  public PeripheralRef getPeripheral() {
     return this.peripheral;
  }

  public void setPeripheral(PeripheralRef peripheral) {
     this.peripheral = peripheral;
  }

  public Integer getPeripheralId() {
     return this.peripheralId;
  }

  public void setPeripheralId(Integer peripheralId) {
     this.peripheralId = peripheralId;
  }

  @XmlElement(name="peripheralSet")
  public ReferenceBean getPeripheralSet() {
     return this.peripheralSet;
  }

  public void setPeripheralSet(ReferenceBean peripheralSet) {
     this.peripheralSet = peripheralSet;
  }

  public String getRefURL() {
     return this.refURL;
  }

  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public Integer getSupervisorCount() {
     return this.supervisorCount;
  }

  public void setSupervisorCount(Integer supervisorCount) {
     this.supervisorCount = supervisorCount;
  }


}
