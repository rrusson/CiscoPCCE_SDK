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
@XmlRootElement(name="agent")
public class Agent extends BaseApiBean {
  private ReferenceBean agentDeskSettings;
  private String agentId;
  private List<AgentServiceEnabled> agentServicesEnabled;
  private List<AgentServiceEnabled> agentServicesToDisable;
  private List<AgentServiceEnabled> agentServicesToEnable;
  private Boolean agentStateTrace;
  private ReferenceBean agentTeam;
  private String attributeValue;
  private List<AttributeValueWithAttribute> attributes;
  private List<AttributeValueWithAttribute> attributesAdded;
  private List<AttributeValueWithAttribute> attributesRemoved;
  private String baseUrlfromRefUrl;
  private Boolean canRemove;
  private Integer changeStamp;
  private String configParam;
  private String correlationId;
  private ReferenceBean datacenter;
  private ReferenceBean defaultSkillGroup;
  private ReferenceBean department;
  private String description;
  private String idFromRefUrl;
  private Boolean markDeletable;
  private String name;
  private PeripheralRef peripheral;
  private String peripheralName;
  private ReferenceBean peripheralSet;
  private Person person;
  private String refURL;
  private Boolean selectedAttribute;
  private Boolean selectedSkillGroup;
  private List<ReferenceBean> skillGroups;
  private List<ReferenceBean> skillGroupsAdded;
  private List<ReferenceBean> skillGroupsRemoved;
  private Boolean supervisor;
  private List<ReferenceBean> supervisorTeams;

  public ReferenceBean getAgentDeskSettings() {
     return this.agentDeskSettings;
  }

  public void setAgentDeskSettings(ReferenceBean agentDeskSettings) {
     this.agentDeskSettings = agentDeskSettings;
  }

  public String getAgentId() {
     return this.agentId;
  }

  public void setAgentId(String agentId) {
     this.agentId = agentId;
  }

  @XmlElementWrapper(name="agentServicesEnabled")
  @XmlElement(name="agentService")
  public List<AgentServiceEnabled> getAgentServicesEnabled() {
     return this.agentServicesEnabled;
  }

  public void setAgentServicesEnabled(List<AgentServiceEnabled> agentServicesEnabled) {
     this.agentServicesEnabled = agentServicesEnabled;
  }

  @XmlElementWrapper(name="agentServicesToDisable")
  @XmlElement(name="agentService")
  public List<AgentServiceEnabled> getAgentServicesToDisable() {
     return this.agentServicesToDisable;
  }

  public void setAgentServicesToDisable(List<AgentServiceEnabled> agentServicesToDisable) {
     this.agentServicesToDisable = agentServicesToDisable;
  }

  @XmlElementWrapper(name="agentServicesToEnable")
  @XmlElement(name="agentService")
  public List<AgentServiceEnabled> getAgentServicesToEnable() {
     return this.agentServicesToEnable;
  }

  public void setAgentServicesToEnable(List<AgentServiceEnabled> agentServicesToEnable) {
     this.agentServicesToEnable = agentServicesToEnable;
  }

  public Boolean getAgentStateTrace() {
     return this.agentStateTrace;
  }

  public void setAgentStateTrace(Boolean agentStateTrace) {
     this.agentStateTrace = agentStateTrace;
  }

  public ReferenceBean getAgentTeam() {
     return this.agentTeam;
  }

  public void setAgentTeam(ReferenceBean agentTeam) {
     this.agentTeam = agentTeam;
  }

  public String getAttributeValue() {
     return this.attributeValue;
  }

  public void setAttributeValue(String attributeValue) {
     this.attributeValue = attributeValue;
  }

  @XmlElementWrapper(name="agentAttributes")
  @XmlElement(name="agentAttribute")
  public List<AttributeValueWithAttribute> getAttributes() {
     return this.attributes;
  }

  public void setAttributes(List<AttributeValueWithAttribute> attributes) {
     this.attributes = attributes;
  }

  @XmlElementWrapper(name="agentAttributesAdded")
  @XmlElement(name="agentAttribute")
  public List<AttributeValueWithAttribute> getAttributesAdded() {
     return this.attributesAdded;
  }

  public void setAttributesAdded(List<AttributeValueWithAttribute> attributesAdded) {
     this.attributesAdded = attributesAdded;
  }

  @XmlElementWrapper(name="agentAttributesRemoved")
  @XmlElement(name="agentAttribute")
  public List<AttributeValueWithAttribute> getAttributesRemoved() {
     return this.attributesRemoved;
  }

  public void setAttributesRemoved(List<AttributeValueWithAttribute> attributesRemoved) {
     this.attributesRemoved = attributesRemoved;
  }

  public String getBaseUrlfromRefUrl() {
     return this.baseUrlfromRefUrl;
  }

  public void setBaseUrlfromRefUrl(String baseUrlfromRefUrl) {
     this.baseUrlfromRefUrl = baseUrlfromRefUrl;
  }

  public Boolean getCanRemove() {
     return this.canRemove;
  }

  public void setCanRemove(Boolean canRemove) {
     this.canRemove = canRemove;
  }

  public Integer getChangeStamp() {
     return this.changeStamp;
  }

  public void setChangeStamp(Integer changeStamp) {
     this.changeStamp = changeStamp;
  }

  public String getConfigParam() {
     return this.configParam;
  }

  public void setConfigParam(String configParam) {
     this.configParam = configParam;
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

  public ReferenceBean getDefaultSkillGroup() {
     return this.defaultSkillGroup;
  }

  public void setDefaultSkillGroup(ReferenceBean defaultSkillGroup) {
     this.defaultSkillGroup = defaultSkillGroup;
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

  public String getIdFromRefUrl() {
     return this.idFromRefUrl;
  }

  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  public Boolean getMarkDeletable() {
     return this.markDeletable;
  }

  public void setMarkDeletable(Boolean markDeletable) {
     this.markDeletable = markDeletable;
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

  public String getPeripheralName() {
     return this.peripheralName;
  }

  public void setPeripheralName(String peripheralName) {
     this.peripheralName = peripheralName;
  }

  @XmlElement(name="peripheralSet")
  public ReferenceBean getPeripheralSet() {
     return this.peripheralSet;
  }

  public void setPeripheralSet(ReferenceBean peripheralSet) {
     this.peripheralSet = peripheralSet;
  }

  public Person getPerson() {
     return this.person;
  }

  public void setPerson(Person person) {
     this.person = person;
  }

  public String getRefURL() {
     return this.refURL;
  }

  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public Boolean getSelectedAttribute() {
     return this.selectedAttribute;
  }

  public void setSelectedAttribute(Boolean selectedAttribute) {
     this.selectedAttribute = selectedAttribute;
  }

  public Boolean getSelectedSkillGroup() {
     return this.selectedSkillGroup;
  }

  public void setSelectedSkillGroup(Boolean selectedSkillGroup) {
     this.selectedSkillGroup = selectedSkillGroup;
  }

  @XmlElementWrapper(name="skillGroups")
  @XmlElement(name="skillGroup")
  public List<ReferenceBean> getSkillGroups() {
     return this.skillGroups;
  }

  public void setSkillGroups(List<ReferenceBean> skillGroups) {
     this.skillGroups = skillGroups;
  }

  @XmlElementWrapper(name="skillGroupsAdded")
  @XmlElement(name="skillGroup")
  public List<ReferenceBean> getSkillGroupsAdded() {
     return this.skillGroupsAdded;
  }

  public void setSkillGroupsAdded(List<ReferenceBean> skillGroupsAdded) {
     this.skillGroupsAdded = skillGroupsAdded;
  }

  @XmlElementWrapper(name="skillGroupsRemoved")
  @XmlElement(name="skillGroup")
  public List<ReferenceBean> getSkillGroupsRemoved() {
     return this.skillGroupsRemoved;
  }

  public void setSkillGroupsRemoved(List<ReferenceBean> skillGroupsRemoved) {
     this.skillGroupsRemoved = skillGroupsRemoved;
  }

  public Boolean getSupervisor() {
     return this.supervisor;
  }

  public void setSupervisor(Boolean supervisor) {
     this.supervisor = supervisor;
  }

  @XmlElementWrapper(name="supervisorTeams")
  @XmlElement(name="supervisorTeam")
  public List<ReferenceBean> getSupervisorTeams() {
     return this.supervisorTeams;
  }

  public void setSupervisorTeams(List<ReferenceBean> supervisorTeams) {
     this.supervisorTeams = supervisorTeams;
  }


  @Path("agent")
  @XmlRootElement(name = "results")
  public static class AgentList extends BaseApiListBean<Agent> {
    @XmlElementWrapper(name = "agents")
    @XmlElement(name = "agent")
    public List<Agent> getItems() {
      return items;
    }

    public void setItems(List<Agent> items) {
      this.items = items;
    }
  }
}
