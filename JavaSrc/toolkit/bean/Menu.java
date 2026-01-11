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


@XmlRootElement(name="menu")
public class Menu extends BaseApiBean {
  private String baseUrlfromRefUrl;
  private ReferenceBean card;
  private Integer changeStamp;
  private String correlationId;
  private ReferenceBean department;
  private List<Feature> features;
  private boolean hidden;
  private String idFromRefUrl;
  private String name;
  private String path;
  private String refURL;
  private boolean systemDefined;
  private String uniqueId;

  public String getBaseUrlfromRefUrl() {
     return this.baseUrlfromRefUrl;
  }

  public void setBaseUrlfromRefUrl(String baseUrlfromRefUrl) {
     this.baseUrlfromRefUrl = baseUrlfromRefUrl;
  }

  public ReferenceBean getCard() {
     return this.card;
  }

  public void setCard(ReferenceBean card) {
     this.card = card;
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

  @XmlElementWrapper(name="features")
  @XmlElement(name="feature")
  public List<Feature> getFeatures() {
     return this.features;
  }

  public void setFeatures(List<Feature> features) {
     this.features = features;
  }

  public boolean getHidden() {
     return this.hidden;
  }

  public void setHidden(boolean hidden) {
     this.hidden = hidden;
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

  public String getPath() {
     return this.path;
  }

  public void setPath(String path) {
     this.path = path;
  }

  public String getRefURL() {
     return this.refURL;
  }

  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public boolean getSystemDefined() {
     return this.systemDefined;
  }

  public void setSystemDefined(boolean systemDefined) {
     this.systemDefined = systemDefined;
  }

  public String getUniqueId() {
     return this.uniqueId;
  }

  public void setUniqueId(String uniqueId) {
     this.uniqueId = uniqueId;
  }


}
