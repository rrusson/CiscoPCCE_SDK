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


@XmlRootElement(name="specialDaySchedule")
public class SpecialDaySchedule extends BaseApiBean {
  private String baseUrlfromRefUrl;
  private Integer changeStamp;
  private String correlationId;
  private String date;
  private ReferenceBean department;
  private String description;
  private String endTime;
  private String idFromRefUrl;
  private String refURL;
  private String startTime;
  private Integer status;
  private ReferenceBean statusReason;

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

  public String getDate() {
     return this.date;
  }

  public void setDate(String date) {
     this.date = date;
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

  public String getEndTime() {
     return this.endTime;
  }

  public void setEndTime(String endTime) {
     this.endTime = endTime;
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

  public String getStartTime() {
     return this.startTime;
  }

  public void setStartTime(String startTime) {
     this.startTime = startTime;
  }

  public Integer getStatus() {
     return this.status;
  }

  public void setStatus(Integer status) {
     this.status = status;
  }

  public ReferenceBean getStatusReason() {
     return this.statusReason;
  }

  public void setStatusReason(ReferenceBean statusReason) {
     this.statusReason = statusReason;
  }


}
