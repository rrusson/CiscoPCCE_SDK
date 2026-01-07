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


@XmlRootElement(name="CVP")
public class CVPServer extends BaseApiBean {
  private String baseUrlfromRefUrl;
  private String correlationId;
  private ReferenceBean datacenter;
  private ReferenceBean department;
  private ICMServiceConfig icm;
  private Integer id;
  private String idFromRefUrl;
  private InfrastructureServiceConfig infrastructure;
  private IVRServiceConfig ivr;
  private MediaServerConfig mediaServer;
  private String refURL;
  private SIPServiceConfig sip;
  private VXMLServiceConfig vxml;

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

  public ICMServiceConfig getIcm() {
     return this.icm;
  }

  public void setIcm(ICMServiceConfig icm) {
     this.icm = icm;
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

  public InfrastructureServiceConfig getInfrastructure() {
     return this.infrastructure;
  }

  public void setInfrastructure(InfrastructureServiceConfig infrastructure) {
     this.infrastructure = infrastructure;
  }

  public IVRServiceConfig getIvr() {
     return this.ivr;
  }

  public void setIvr(IVRServiceConfig ivr) {
     this.ivr = ivr;
  }

  public MediaServerConfig getMediaServer() {
     return this.mediaServer;
  }

  public void setMediaServer(MediaServerConfig mediaServer) {
     this.mediaServer = mediaServer;
  }

  public String getRefURL() {
     return this.refURL;
  }

  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public SIPServiceConfig getSip() {
     return this.sip;
  }

  public void setSip(SIPServiceConfig sip) {
     this.sip = sip;
  }

  public VXMLServiceConfig getVxml() {
     return this.vxml;
  }

  public void setVxml(VXMLServiceConfig vxml) {
     this.vxml = vxml;
  }


}
