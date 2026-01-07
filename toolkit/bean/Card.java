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


@XmlRootElement(name="card")
public class Card extends BaseApiBean {
  private String baseUrlfromRefUrl;
  private Integer changeStamp;
  private String color;
  private String correlationId;
  private ReferenceBean department;
  private String header;
  private String icon;
  private String idFromRefUrl;
  private List<Menu> menus;
  private String refURL;
  private boolean systemDefined;
  private String uniqueId;

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

  public String getColor() {
     return this.color;
  }

  public void setColor(String color) {
     this.color = color;
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

  public String getHeader() {
     return this.header;
  }

  public void setHeader(String header) {
     this.header = header;
  }

  public String getIcon() {
     return this.icon;
  }

  public void setIcon(String icon) {
     this.icon = icon;
  }

  public String getIdFromRefUrl() {
     return this.idFromRefUrl;
  }

  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  public List<Menu> getMenus() {
     return this.menus;
  }

  public void setMenus(List<Menu> menus) {
     this.menus = menus;
  }

  public String getRefURL() {
     return this.refURL;
  }

  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public boolean getSystemDefined() {
     return this.systemDefined;
  }

  public void setSystemDefined(boolean systemDefined) {
     this.systemDefined = systemDefined;
  }

  public String getUniqueId() {
     return this.uniqueId;
  }

  public void setUniqueId(String uniqueId) {
     this.uniqueId = uniqueId;
  }


}
