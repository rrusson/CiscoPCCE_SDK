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


@Path("routingpattern")
@XmlRootElement(name="routingPattern")
public class RoutingPattern extends BaseApiBean {
  private String baseUrlfromRefUrl;
  private Integer changeStamp;
  private String configParam;
  private String correlationId;
  private ReferenceBean datacenter;
  private ReferenceBean department;
  private String description;
  private String destination;
  private String idFromRefUrl;
  private String pattern;
  private Integer patternType;
  private String refURL;
  private Integer rnaTimeout;
  private Boolean sendToOriginator;

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

  public String getDestination() {
     return this.destination;
  }

  public void setDestination(String destination) {
     this.destination = destination;
  }

  public String getIdFromRefUrl() {
     return this.idFromRefUrl;
  }

  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  public String getPattern() {
     return this.pattern;
  }

  public void setPattern(String pattern) {
     this.pattern = pattern;
  }

  public Integer getPatternType() {
     return this.patternType;
  }

  public void setPatternType(Integer patternType) {
     this.patternType = patternType;
  }

  public String getRefURL() {
     return this.refURL;
  }

  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public Integer getRnaTimeout() {
     return this.rnaTimeout;
  }

  public void setRnaTimeout(Integer rnaTimeout) {
     this.rnaTimeout = rnaTimeout;
  }

  public Boolean getSendToOriginator() {
     return this.sendToOriginator;
  }

  public void setSendToOriginator(Boolean sendToOriginator) {
     this.sendToOriginator = sendToOriginator;
  }


  @Path("routingpattern")
  @XmlRootElement(name = "results")
  public static class RoutingPatternList extends BaseApiListBean<RoutingPattern> {
    @XmlElementWrapper(name = "routingPatterns")
    @XmlElement(name = "routingPattern")
    public List<RoutingPattern> getItems() {
      return items;
    }

    public void setItems(List<RoutingPattern> items) {
      this.items = items;
    }
  }
}
