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


@Path("sipservergroup")
@XmlRootElement(name="sipServerGroup")
public class SipServerGroup extends BaseApiBean {
  private String baseUrlfromRefUrl;
  private Integer changeStamp;
  private String correlationId;
  private ReferenceBean datacenter;
  private Boolean defaultGroup;
  private ReferenceBean department;
  private String description;
  private List<SipServerElement> elements;
  private String idFromRefUrl;
  private String name;
  private Integer noOfElements;
  private String refURL;
  private SipServerType type;

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

  public Boolean getDefaultGroup() {
     return this.defaultGroup;
  }

  public void setDefaultGroup(Boolean defaultGroup) {
     this.defaultGroup = defaultGroup;
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

  @XmlElementWrapper(name="elements")
  @XmlElement(name="element")
  public List<SipServerElement> getElements() {
     return this.elements;
  }

  public void setElements(List<SipServerElement> elements) {
     this.elements = elements;
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

  public Integer getNoOfElements() {
     return this.noOfElements;
  }

  public void setNoOfElements(Integer noOfElements) {
     this.noOfElements = noOfElements;
  }

  public String getRefURL() {
     return this.refURL;
  }

  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public SipServerType getType() {
     return this.type;
  }

  public void setType(SipServerType type) {
     this.type = type;
  }


  @Path("sipservergroup")
  @XmlRootElement(name = "results")
  public static class SipServerGroupList extends BaseApiListBean<SipServerGroup> {
    @XmlElementWrapper(name = "sipServerGroups")
    @XmlElement(name = "sipServerGroup")
    public List<SipServerGroup> getItems() {
      return items;
    }

    public void setItems(List<SipServerGroup> items) {
      this.items = items;
    }
  }
}
