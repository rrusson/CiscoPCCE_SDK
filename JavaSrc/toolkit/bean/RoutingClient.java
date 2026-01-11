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


@Path("secondaryaddress")
@XmlRootElement(name="routingClient")
public class RoutingClient extends BaseApiBean {
  private String baseUrlfromRefUrl;
  private Integer changeStamp;
  private Short clientType;
  private String correlationId;
  private ReferenceBean department;
  private String idFromRefUrl;
  private Short lateThreshold;
  private ReferenceBean logicalController;
  private Boolean markDeletable;
  private String name;
  private PeripheralRef peripheral;
  private String refURL;
  private Short timeoutLimit;
  private Short timeoutThreshold;

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

  public Short getClientType() {
     return this.clientType;
  }

  public void setClientType(Short clientType) {
     this.clientType = clientType;
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

  public Short getLateThreshold() {
     return this.lateThreshold;
  }

  public void setLateThreshold(Short lateThreshold) {
     this.lateThreshold = lateThreshold;
  }

  public ReferenceBean getLogicalController() {
     return this.logicalController;
  }

  public void setLogicalController(ReferenceBean logicalController) {
     this.logicalController = logicalController;
  }

  public Boolean getMarkDeletable() {
     return this.markDeletable;
  }

  public void setMarkDeletable(Boolean markDeletable) {
     this.markDeletable = markDeletable;
  }

  public String getName() {
     return this.name;
  }

  public void setName(String name) {
     this.name = name;
  }

  public PeripheralRef getPeripheral() {
     return this.peripheral;
  }

  public void setPeripheral(PeripheralRef peripheral) {
     this.peripheral = peripheral;
  }

  public String getRefURL() {
     return this.refURL;
  }

  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public Short getTimeoutLimit() {
     return this.timeoutLimit;
  }

  public void setTimeoutLimit(Short timeoutLimit) {
     this.timeoutLimit = timeoutLimit;
  }

  public Short getTimeoutThreshold() {
     return this.timeoutThreshold;
  }

  public void setTimeoutThreshold(Short timeoutThreshold) {
     this.timeoutThreshold = timeoutThreshold;
  }


  @Path("secondaryaddress")
  @XmlRootElement(name = "results")
  public static class RoutingClientList extends BaseApiListBean<RoutingClient> {
    @XmlElementWrapper(name = "routingClients")
    @XmlElement(name = "routingClient")
    public List<RoutingClient> getItems() {
      return items;
    }

    public void setItems(List<RoutingClient> items) {
      this.items = items;
    }
  }
}
