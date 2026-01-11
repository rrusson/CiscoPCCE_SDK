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


@XmlRootElement(name="product")
public class ECEProduct extends BaseApiBean {
  private String build;
  private String description;
  private String installedBy;
  private String integrationInfo;
  private String name;
  private String oneOffNumber;
  private String psCustomizationNumber;
  private String version;

  public String getBuild() {
     return this.build;
  }

  public void setBuild(String build) {
     this.build = build;
  }

  public String getDescription() {
     return this.description;
  }

  public void setDescription(String description) {
     this.description = description;
  }

  public String getInstalledBy() {
     return this.installedBy;
  }

  public void setInstalledBy(String installedBy) {
     this.installedBy = installedBy;
  }

  public String getIntegrationInfo() {
     return this.integrationInfo;
  }

  public void setIntegrationInfo(String integrationInfo) {
     this.integrationInfo = integrationInfo;
  }

  public String getName() {
     return this.name;
  }

  public void setName(String name) {
     this.name = name;
  }

  public String getOneOffNumber() {
     return this.oneOffNumber;
  }

  public void setOneOffNumber(String oneOffNumber) {
     this.oneOffNumber = oneOffNumber;
  }

  public String getPsCustomizationNumber() {
     return this.psCustomizationNumber;
  }

  public void setPsCustomizationNumber(String psCustomizationNumber) {
     this.psCustomizationNumber = psCustomizationNumber;
  }

  public String getVersion() {
     return this.version;
  }

  public void setVersion(String version) {
     this.version = version;
  }


}
