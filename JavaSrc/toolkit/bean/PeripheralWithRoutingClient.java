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
@XmlRootElement(name="peripheral")
public class PeripheralWithRoutingClient extends BaseApiBean {
  private String baseUrlfromRefUrl;
  private Integer changeStamp;
  private Short clientType;
  private String correlationId;
  private ReferenceBean defaultDeskSetting;
  private ReferenceBean department;
  private boolean hideRefURL;
  private String hostName1;
  private String hostName2;
  private Integer hostPort1;
  private Integer hostPort2;
  private String idFromRefUrl;
  private Boolean markDeletable;
  private String name;
  private ReferenceBean networkTarget;
  private ReferenceBean peripheralGateway;
  private Integer peripheralId;
  private String peripheralName;
  private RoutingClient routingClient;
  private Integer routingClientId;
  private Integer routingType;
  private String routingTypeForMROnDC;

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

  public ReferenceBean getDefaultDeskSetting() {
     return this.defaultDeskSetting;
  }

  public void setDefaultDeskSetting(ReferenceBean defaultDeskSetting) {
     this.defaultDeskSetting = defaultDeskSetting;
  }

  public ReferenceBean getDepartment() {
     return this.department;
  }

  public void setDepartment(ReferenceBean department) {
     this.department = department;
  }

  public boolean getHideRefURL() {
     return this.hideRefURL;
  }

  public void setHideRefURL(boolean hideRefURL) {
     this.hideRefURL = hideRefURL;
  }

  public String getHostName1() {
     return this.hostName1;
  }

  public void setHostName1(String hostName1) {
     this.hostName1 = hostName1;
  }

  public String getHostName2() {
     return this.hostName2;
  }

  public void setHostName2(String hostName2) {
     this.hostName2 = hostName2;
  }

  public Integer getHostPort1() {
     return this.hostPort1;
  }

  public void setHostPort1(Integer hostPort1) {
     this.hostPort1 = hostPort1;
  }

  public Integer getHostPort2() {
     return this.hostPort2;
  }

  public void setHostPort2(Integer hostPort2) {
     this.hostPort2 = hostPort2;
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

  public String getName() {
     return this.name;
  }

  public void setName(String name) {
     this.name = name;
  }

  public ReferenceBean getNetworkTarget() {
     return this.networkTarget;
  }

  public void setNetworkTarget(ReferenceBean networkTarget) {
     this.networkTarget = networkTarget;
  }

  public ReferenceBean getPeripheralGateway() {
     return this.peripheralGateway;
  }

  public void setPeripheralGateway(ReferenceBean peripheralGateway) {
     this.peripheralGateway = peripheralGateway;
  }

  public Integer getPeripheralId() {
     return this.peripheralId;
  }

  public void setPeripheralId(Integer peripheralId) {
     this.peripheralId = peripheralId;
  }

  public String getPeripheralName() {
     return this.peripheralName;
  }

  public void setPeripheralName(String peripheralName) {
     this.peripheralName = peripheralName;
  }

  public RoutingClient getRoutingClient() {
     return this.routingClient;
  }

  public void setRoutingClient(RoutingClient routingClient) {
     this.routingClient = routingClient;
  }

  public Integer getRoutingClientId() {
     return this.routingClientId;
  }

  public void setRoutingClientId(Integer routingClientId) {
     this.routingClientId = routingClientId;
  }

  public Integer getRoutingType() {
     return this.routingType;
  }

  public void setRoutingType(Integer routingType) {
     this.routingType = routingType;
  }

  public String getRoutingTypeForMROnDC() {
     return this.routingTypeForMROnDC;
  }

  public void setRoutingTypeForMROnDC(String routingTypeForMROnDC) {
     this.routingTypeForMROnDC = routingTypeForMROnDC;
  }


  @Path("secondaryaddress")
  @XmlRootElement(name = "results")
  public static class PeripheralWithRoutingClientList extends BaseApiListBean<PeripheralWithRoutingClient> {
    @XmlElementWrapper(name = "peripherals")
    @XmlElement(name = "peripheral")
    public List<PeripheralWithRoutingClient> getItems() {
      return items;
    }

    public void setItems(List<PeripheralWithRoutingClient> items) {
      this.items = items;
    }
  }
}
