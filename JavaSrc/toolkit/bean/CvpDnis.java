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


@XmlRootElement(name="cvpDnis")
public class CvpDnis extends BaseApiBean {
  private String baseUrlfromRefUrl;
  private String correlationId;
  private ReferenceBean datacenter;
  private ReferenceBean department;
  private String dnisList;
  private String hostname;
  private Integer id;
  private String idFromRefUrl;
  private String refURL;

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

  public String getDnisList() {
     return this.dnisList;
  }

  public void setDnisList(String dnisList) {
     this.dnisList = dnisList;
  }

  public String getHostname() {
     return this.hostname;
  }

  public void setHostname(String hostname) {
     this.hostname = hostname;
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

  public String getRefURL() {
     return this.refURL;
  }

  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }


}
