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
public class DuplexedMachineErrorDetail extends BaseApiBean {
  private List<MachineType> machineTypes;
  private String periperhalSetName;

  public List<MachineType> getMachineTypes() {
     return this.machineTypes;
  }

  public void setMachineTypes(List<MachineType> machineTypes) {
     this.machineTypes = machineTypes;
  }

  public String getPeriperhalSetName() {
     return this.periperhalSetName;
  }

  public void setPeriperhalSetName(String periperhalSetName) {
     this.periperhalSetName = periperhalSetName;
  }


}
