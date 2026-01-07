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


@XmlRootElement(name="errorDetail")
public class MachineErrorDetail extends BaseApiBean {
  private String machineName;
  private MachineType machineType;
  private String side;

  public String getMachineName() {
     return this.machineName;
  }

  public void setMachineName(String machineName) {
     this.machineName = machineName;
  }

  public MachineType getMachineType() {
     return this.machineType;
  }

  public void setMachineType(MachineType machineType) {
     this.machineType = machineType;
  }

  public String getSide() {
     return this.side;
  }

  public void setSide(String side) {
     this.side = side;
  }


}
