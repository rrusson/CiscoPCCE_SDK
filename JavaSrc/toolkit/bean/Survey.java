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


@XmlRootElement(name="survey")
public class Survey extends BaseApiBean {
  private String application;
  private String baseUrlfromRefUrl;
  private Integer changeStamp;
  private String correlationId;
  private ReferenceBean department;
  private String enterpriseName;
  private String idFromRefUrl;
  private Boolean markDeletable;
  private SurveyQuestion question;
  private String refURL;
  private Integer surveyType;

  public String getApplication() {
     return this.application;
  }

  public void setApplication(String application) {
     this.application = application;
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

  public String getEnterpriseName() {
     return this.enterpriseName;
  }

  public void setEnterpriseName(String enterpriseName) {
     this.enterpriseName = enterpriseName;
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

  @XmlElement(name="surveyDetail")
  public SurveyQuestion getQuestion() {
     return this.question;
  }

  public void setQuestion(SurveyQuestion question) {
     this.question = question;
  }

  public String getRefURL() {
     return this.refURL;
  }

  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public Integer getSurveyType() {
     return this.surveyType;
  }

  public void setSurveyType(Integer surveyType) {
     this.surveyType = surveyType;
  }


}
