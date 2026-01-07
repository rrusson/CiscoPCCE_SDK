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


@Path("businesshour")
@XmlRootElement(name="realTimeStatus")
public class BusinessHourRealTimeStatus extends BaseApiBean {
  private String baseUrlfromRefUrl;
  private String correlationId;
  private ReferenceBean department;
  private String idFromRefUrl;
  private String refURL;
  private Integer status;
  private ReferenceBean statusReason;

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

  public String getRefURL() {
     return this.refURL;
  }

  public void setRefURL(String refURL) {
     this.refURL = refURL;
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


  @Path("businesshour")
  @XmlRootElement(name = "results")
  public static class BusinessHourRealTimeStatusList extends BaseApiListBean<BusinessHourRealTimeStatus> {
    @XmlElementWrapper(name = "realTimeStatuss")
    @XmlElement(name = "realTimeStatus")
    public List<BusinessHourRealTimeStatus> getItems() {
      return items;
    }

    public void setItems(List<BusinessHourRealTimeStatus> items) {
      this.items = items;
    }
  }
}
