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


@Path("datacenter")
@XmlRootElement(name="datacenter")
public class DataCenter extends BaseApiBean {
  private AgentPG agentPG;
  private String baseUrlfromRefUrl;
  private boolean cMPublisherAssociationRequired;
  private Integer changeStamp;
  private String correlationId;
  private ReferenceBean department;
  private Boolean eceConfigured;
  private String idFromRefUrl;
  private MultiChannelPG multiChannelPG;
  private String name;
  private String refURL;
  private String sideAPGAddress;
  private String sideBPGAddress;
  private VruPG vruPG;

  public AgentPG getAgentPG() {
     return this.agentPG;
  }

  public void setAgentPG(AgentPG agentPG) {
     this.agentPG = agentPG;
  }

  public String getBaseUrlfromRefUrl() {
     return this.baseUrlfromRefUrl;
  }

  public void setBaseUrlfromRefUrl(String baseUrlfromRefUrl) {
     this.baseUrlfromRefUrl = baseUrlfromRefUrl;
  }

  public boolean getCMPublisherAssociationRequired() {
     return this.cMPublisherAssociationRequired;
  }

  public void setCMPublisherAssociationRequired(boolean cMPublisherAssociationRequired) {
     this.cMPublisherAssociationRequired = cMPublisherAssociationRequired;
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

  public Boolean getEceConfigured() {
     return this.eceConfigured;
  }

  public void setEceConfigured(Boolean eceConfigured) {
     this.eceConfigured = eceConfigured;
  }

  public String getIdFromRefUrl() {
     return this.idFromRefUrl;
  }

  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  public MultiChannelPG getMultiChannelPG() {
     return this.multiChannelPG;
  }

  public void setMultiChannelPG(MultiChannelPG multiChannelPG) {
     this.multiChannelPG = multiChannelPG;
  }

  public String getName() {
     return this.name;
  }

  public void setName(String name) {
     this.name = name;
  }

  public String getRefURL() {
     return this.refURL;
  }

  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public String getSideAPGAddress() {
     return this.sideAPGAddress;
  }

  public void setSideAPGAddress(String sideAPGAddress) {
     this.sideAPGAddress = sideAPGAddress;
  }

  public String getSideBPGAddress() {
     return this.sideBPGAddress;
  }

  public void setSideBPGAddress(String sideBPGAddress) {
     this.sideBPGAddress = sideBPGAddress;
  }

  public VruPG getVruPG() {
     return this.vruPG;
  }

  public void setVruPG(VruPG vruPG) {
     this.vruPG = vruPG;
  }


  @Path("datacenter")
  @XmlRootElement(name = "results")
  public static class DataCenterList extends BaseApiListBean<DataCenter> {
    @XmlElementWrapper(name = "datacenters")
    @XmlElement(name = "datacenter")
    public List<DataCenter> getItems() {
      return items;
    }

    public void setItems(List<DataCenter> items) {
      this.items = items;
    }
  }
}
