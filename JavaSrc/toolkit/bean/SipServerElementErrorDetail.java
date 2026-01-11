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
public class SipServerElementErrorDetail extends BaseApiBean {
  private String address;
  private String field;
  private Integer max;
  private Integer min;

  public String getAddress() {
     return this.address;
  }

  public void setAddress(String address) {
     this.address = address;
  }

  public String getField() {
     return this.field;
  }

  public void setField(String field) {
     this.field = field;
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


}
