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


@Path("location")
@XmlRootElement(name="location")
public class Location extends BaseApiBean {
  private String baseUrlfromRefUrl;
  private Integer changeStamp;
  private String correlationId;
  private String cucmHostAddress;
  private List<ReferenceBean> datacenters;
  private ReferenceBean department;
  private String description;
  private List<ReferenceBean> gateways;
  private String idFromRefUrl;
  private String locationCode;
  private String locationName;
  private String refURL;

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

  public String getCucmHostAddress() {
     return this.cucmHostAddress;
  }

  public void setCucmHostAddress(String cucmHostAddress) {
     this.cucmHostAddress = cucmHostAddress;
  }

  @XmlElementWrapper(name="datacenters")
  @XmlElement(name="datacenter")
  public List<ReferenceBean> getDatacenters() {
     return this.datacenters;
  }

  public void setDatacenters(List<ReferenceBean> datacenters) {
     this.datacenters = datacenters;
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

  @XmlElementWrapper(name="gateways")
  @XmlElement(name="gateway")
  public List<ReferenceBean> getGateways() {
     return this.gateways;
  }

  public void setGateways(List<ReferenceBean> gateways) {
     this.gateways = gateways;
  }

  public String getIdFromRefUrl() {
     return this.idFromRefUrl;
  }

  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  public String getLocationCode() {
     return this.locationCode;
  }

  public void setLocationCode(String locationCode) {
     this.locationCode = locationCode;
  }

  public String getLocationName() {
     return this.locationName;
  }

  public void setLocationName(String locationName) {
     this.locationName = locationName;
  }

  public String getRefURL() {
     return this.refURL;
  }

  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }


  @Path("location")
  @XmlRootElement(name = "results")
  public static class LocationList extends BaseApiListBean<Location> {
    @XmlElementWrapper(name = "locations")
    @XmlElement(name = "location")
    public List<Location> getItems() {
      return items;
    }

    public void setItems(List<Location> items) {
      this.items = items;
    }
  }
}
