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


@XmlRootElement(name="icm")
public class ICMServiceConfig extends BaseApiBean {
  private Boolean enableSecureVRU;
  private Boolean enableTrunkUtilization;
  private String gatewaylist;
  private List<ReferenceBean> gateways;
  private Integer maxDNISLength;
  private Integer maxGatewayPorts;
  private Integer vruConnectionPort;

  public Boolean getEnableSecureVRU() {
     return this.enableSecureVRU;
  }

  public void setEnableSecureVRU(Boolean enableSecureVRU) {
     this.enableSecureVRU = enableSecureVRU;
  }

  public Boolean getEnableTrunkUtilization() {
     return this.enableTrunkUtilization;
  }

  public void setEnableTrunkUtilization(Boolean enableTrunkUtilization) {
     this.enableTrunkUtilization = enableTrunkUtilization;
  }

  public String getGatewaylist() {
     return this.gatewaylist;
  }

  public void setGatewaylist(String gatewaylist) {
     this.gatewaylist = gatewaylist;
  }

  @XmlElementWrapper(name="gateways")
  @XmlElement(name="gateway")
  public List<ReferenceBean> getGateways() {
     return this.gateways;
  }

  public void setGateways(List<ReferenceBean> gateways) {
     this.gateways = gateways;
  }

  public Integer getMaxDNISLength() {
     return this.maxDNISLength;
  }

  public void setMaxDNISLength(Integer maxDNISLength) {
     this.maxDNISLength = maxDNISLength;
  }

  public Integer getMaxGatewayPorts() {
     return this.maxGatewayPorts;
  }

  public void setMaxGatewayPorts(Integer maxGatewayPorts) {
     this.maxGatewayPorts = maxGatewayPorts;
  }

  public Integer getVruConnectionPort() {
     return this.vruConnectionPort;
  }

  public void setVruConnectionPort(Integer vruConnectionPort) {
     this.vruConnectionPort = vruConnectionPort;
  }


}
