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
public class MachineTypeNumberOutOfRangeErrorDetail extends BaseApiBean {
  private Integer actual;
  private List<MachineType> machineTypes;
  private Integer max;
  private Integer min;
  private String peripheralSetName;

  public Integer getActual() {
     return this.actual;
  }

  public void setActual(Integer actual) {
     this.actual = actual;
  }

  public List<MachineType> getMachineTypes() {
     return this.machineTypes;
  }

  public void setMachineTypes(List<MachineType> machineTypes) {
     this.machineTypes = machineTypes;
  }

  public Integer getMax() {
     return this.max;
  }

  public void setMax(Integer max) {
     this.max = max;
  }

  public Integer getMin() {
     return this.min;
  }

  public void setMin(Integer min) {
     this.min = min;
  }

  public String getPeripheralSetName() {
     return this.peripheralSetName;
  }

  public void setPeripheralSetName(String peripheralSetName) {
     this.peripheralSetName = peripheralSetName;
  }


}
