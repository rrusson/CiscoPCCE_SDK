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


@XmlRootElement(name="ReasonCode")
public class ReasonCodeConfig extends BaseApiBean {
  private Boolean active;
  private String category;
  private String code;
  private String forAll;
  private int id;
  private String label;
  private Long lastmodified;
  private Boolean systemCode;
  private String uri;

  public Boolean getActive() {
     return this.active;
  }

  public void setActive(Boolean active) {
     this.active = active;
  }

  public String getCategory() {
     return this.category;
  }

  public void setCategory(String category) {
     this.category = category;
  }

  public String getCode() {
     return this.code;
  }

  public void setCode(String code) {
     this.code = code;
  }

  public String getForAll() {
     return this.forAll;
  }

  public void setForAll(String forAll) {
     this.forAll = forAll;
  }

  public int getId() {
     return this.id;
  }

  public void setId(int id) {
     this.id = id;
  }

  public String getLabel() {
     return this.label;
  }

  public void setLabel(String label) {
     this.label = label;
  }

  public Long getLastmodified() {
     return this.lastmodified;
  }

  public void setLastmodified(Long lastmodified) {
     this.lastmodified = lastmodified;
  }

  public Boolean getSystemCode() {
     return this.systemCode;
  }

  public void setSystemCode(Boolean systemCode) {
     this.systemCode = systemCode;
  }

  public String getUri() {
     return this.uri;
  }

  public void setUri(String uri) {
     this.uri = uri;
  }


}
