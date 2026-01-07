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


@Path("businesshourstatusreason")
@XmlRootElement(name="businessHourStatusReason")
public class BusinessHourStatusReason extends BaseApiBean {
  private String baseUrlfromRefUrl;
  private String category;
  private Integer changeStamp;
  private String correlationId;
  private ReferenceBean department;
  private String idFromRefUrl;
  private Integer reasonCode;
  private String reasonText;
  private String refURL;

  public String getBaseUrlfromRefUrl() {
     return this.baseUrlfromRefUrl;
  }

  public void setBaseUrlfromRefUrl(String baseUrlfromRefUrl) {
     this.baseUrlfromRefUrl = baseUrlfromRefUrl;
  }

  public String getCategory() {
     return this.category;
  }

  public void setCategory(String category) {
     this.category = category;
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

  public String getIdFromRefUrl() {
     return this.idFromRefUrl;
  }

  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  public Integer getReasonCode() {
     return this.reasonCode;
  }

  public void setReasonCode(Integer reasonCode) {
     this.reasonCode = reasonCode;
  }

  public String getReasonText() {
     return this.reasonText;
  }

  public void setReasonText(String reasonText) {
     this.reasonText = reasonText;
  }

  public String getRefURL() {
     return this.refURL;
  }

  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }


  @Path("businesshourstatusreason")
  @XmlRootElement(name = "results")
  public static class BusinessHourStatusReasonList extends BaseApiListBean<BusinessHourStatusReason> {
    @XmlElementWrapper(name = "businessHourStatusReasons")
    @XmlElement(name = "businessHourStatusReason")
    public List<BusinessHourStatusReason> getItems() {
      return items;
    }

    public void setItems(List<BusinessHourStatusReason> items) {
      this.items = items;
    }
  }
}
