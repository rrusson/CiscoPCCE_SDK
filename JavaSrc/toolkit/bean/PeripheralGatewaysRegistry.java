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


public class PeripheralGatewaysRegistry extends BaseApiBean {
  private String clientType;
  private Integer logicalControllerID;
  private List<PeripheralWithRoutingClient> peripheralDetails;
  private String pgName;

  public String getClientType() {
     return this.clientType;
  }

  public void setClientType(String clientType) {
     this.clientType = clientType;
  }

  public Integer getLogicalControllerID() {
     return this.logicalControllerID;
  }

  public void setLogicalControllerID(Integer logicalControllerID) {
     this.logicalControllerID = logicalControllerID;
  }

  @XmlElementWrapper(name="peripherals")
  @XmlElement(name="peripheral")
  public List<PeripheralWithRoutingClient> getPeripheralDetails() {
     return this.peripheralDetails;
  }

  public void setPeripheralDetails(List<PeripheralWithRoutingClient> peripheralDetails) {
     this.peripheralDetails = peripheralDetails;
  }

  public String getPgName() {
     return this.pgName;
  }

  public void setPgName(String pgName) {
     this.pgName = pgName;
  }


}
