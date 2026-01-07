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


@Path("cloudconnectsettings")
@XmlRootElement(name="dataSource")
public class DataSource extends BaseApiBean {
  private String baseUrlfromRefUrl;
  private String correlationId;
  private ReferenceBean department;
  private Integer id;
  private String idFromRefUrl;
  private String refURL;
  private DataSourceDetails sideA;
  private DataSourceDetails sideB;

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

  public DataSourceDetails getSideA() {
     return this.sideA;
  }

  public void setSideA(DataSourceDetails sideA) {
     this.sideA = sideA;
  }

  public DataSourceDetails getSideB() {
     return this.sideB;
  }

  public void setSideB(DataSourceDetails sideB) {
     this.sideB = sideB;
  }


  @Path("cloudconnectsettings")
  @XmlRootElement(name = "results")
  public static class DataSourceList extends BaseApiListBean<DataSource> {
    @XmlElementWrapper(name = "dataSources")
    @XmlElement(name = "dataSource")
    public List<DataSource> getItems() {
      return items;
    }

    public void setItems(List<DataSource> items) {
      this.items = items;
    }
  }
}
