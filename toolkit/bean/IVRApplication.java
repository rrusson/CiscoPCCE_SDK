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


@Path("transferablefiles")
@XmlRootElement(name="IVRApplication")
public class IVRApplication extends BaseApiBean {
  private String baseUrlfromRefUrl;
  private Integer changeStamp;
  private String correlationId;
  private String createDateTime;
  private ReferenceBean department;
  private String fileName;
  private String idFromRefUrl;
  private String refURL;
  private String size;

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

  public String getCreateDateTime() {
     return this.createDateTime;
  }

  public void setCreateDateTime(String createDateTime) {
     this.createDateTime = createDateTime;
  }

  public ReferenceBean getDepartment() {
     return this.department;
  }

  public void setDepartment(ReferenceBean department) {
     this.department = department;
  }

  public String getFileName() {
     return this.fileName;
  }

  public void setFileName(String fileName) {
     this.fileName = fileName;
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

  public String getSize() {
     return this.size;
  }

  public void setSize(String size) {
     this.size = size;
  }


  @Path("transferablefiles")
  @XmlRootElement(name = "results")
  public static class IVRApplicationList extends BaseApiListBean<IVRApplication> {
    @XmlElementWrapper(name = "IVRApplications")
    @XmlElement(name = "IVRApplication")
    public List<IVRApplication> getItems() {
      return items;
    }

    public void setItems(List<IVRApplication> items) {
      this.items = items;
    }
  }
}
