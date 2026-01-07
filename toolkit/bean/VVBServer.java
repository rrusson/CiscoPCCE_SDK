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


@XmlRootElement(name="VVB")
public class VVBServer extends BaseApiBean {
  private List<Application> applications;
  private List<AsrServer> asrServers;
  private String baseUrlfromRefUrl;
  private String correlationId;
  private ReferenceBean datacenter;
  private ReferenceBean department;
  private Integer id;
  private String idFromRefUrl;
  private MediaConfig media;
  private String refURL;
  private SecurityConfig security;
  private List<TtsServer> ttsServers;

  @XmlElementWrapper(name="applications")
  @XmlElement(name="application")
  public List<Application> getApplications() {
     return this.applications;
  }

  public void setApplications(List<Application> applications) {
     this.applications = applications;
  }

  @XmlElementWrapper(name="asrServers")
  @XmlElement(name="asrServer")
  public List<AsrServer> getAsrServers() {
     return this.asrServers;
  }

  public void setAsrServers(List<AsrServer> asrServers) {
     this.asrServers = asrServers;
  }

  public String getBaseUrlfromRefUrl() {
     return this.baseUrlfromRefUrl;
  }

  public void setBaseUrlfromRefUrl(String baseUrlfromRefUrl) {
     this.baseUrlfromRefUrl = baseUrlfromRefUrl;
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

  public MediaConfig getMedia() {
     return this.media;
  }

  public void setMedia(MediaConfig media) {
     this.media = media;
  }

  public String getRefURL() {
     return this.refURL;
  }

  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public SecurityConfig getSecurity() {
     return this.security;
  }

  public void setSecurity(SecurityConfig security) {
     this.security = security;
  }

  @XmlElementWrapper(name="ttsServers")
  @XmlElement(name="ttsServer")
  public List<TtsServer> getTtsServers() {
     return this.ttsServers;
  }

  public void setTtsServers(List<TtsServer> ttsServers) {
     this.ttsServers = ttsServers;
  }


}
