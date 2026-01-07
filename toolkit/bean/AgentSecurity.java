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


@Path("agentsecurity")
@XmlRootElement(name="agentSecurity")
public class AgentSecurity extends BaseApiBean {
  private Integer agentsWithoutAdvancedHashing;
  private String baseUrlfromRefUrl;
  private Integer changeStamp;
  private String correlationId;
  private ReferenceBean department;
  private Boolean enforceAdvancedHashing;
  private String idFromRefUrl;
  private String refURL;
  private Integer unsupportedPeripheralGateways;

  public Integer getAgentsWithoutAdvancedHashing() {
     return this.agentsWithoutAdvancedHashing;
  }

  public void setAgentsWithoutAdvancedHashing(Integer agentsWithoutAdvancedHashing) {
     this.agentsWithoutAdvancedHashing = agentsWithoutAdvancedHashing;
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

  public ReferenceBean getDepartment() {
     return this.department;
  }

  public void setDepartment(ReferenceBean department) {
     this.department = department;
  }

  public Boolean getEnforceAdvancedHashing() {
     return this.enforceAdvancedHashing;
  }

  public void setEnforceAdvancedHashing(Boolean enforceAdvancedHashing) {
     this.enforceAdvancedHashing = enforceAdvancedHashing;
  }

  public String getIdFromRefUrl() {
     return this.idFromRefUrl;
  }

  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  public String getRefURL() {
     return this.refURL;
  }

  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public Integer getUnsupportedPeripheralGateways() {
     return this.unsupportedPeripheralGateways;
  }

  public void setUnsupportedPeripheralGateways(Integer unsupportedPeripheralGateways) {
     this.unsupportedPeripheralGateways = unsupportedPeripheralGateways;
  }


  @Path("agentsecurity")
  @XmlRootElement(name = "results")
  public static class AgentSecurityList extends BaseApiListBean<AgentSecurity> {
    @XmlElementWrapper(name = "agentSecuritys")
    @XmlElement(name = "agentSecurity")
    public List<AgentSecurity> getItems() {
      return items;
    }

    public void setItems(List<AgentSecurity> items) {
      this.items = items;
    }
  }
}
