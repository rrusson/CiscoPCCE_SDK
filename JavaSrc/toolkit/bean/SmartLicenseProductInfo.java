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


@Path("smartlicense")
@XmlRootElement(name="smartlicenseproductinfo")
public class SmartLicenseProductInfo extends BaseApiBean {
  private String baseUrlfromRefUrl;
  private Integer changeStamp;
  private String correlationId;
  private ReferenceBean department;
  private String idFromRefUrl;
  private Integer privacyEnabled;
  private String productDescription;
  private String productDisplayName;
  private Integer productEnvironment;
  private String productTag;
  private String productVersion;
  private String refURL;
  private Integer smartLicenseProductID;

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

  public String getIdFromRefUrl() {
     return this.idFromRefUrl;
  }

  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  public Integer getPrivacyEnabled() {
     return this.privacyEnabled;
  }

  public void setPrivacyEnabled(Integer privacyEnabled) {
     this.privacyEnabled = privacyEnabled;
  }

  public String getProductDescription() {
     return this.productDescription;
  }

  public void setProductDescription(String productDescription) {
     this.productDescription = productDescription;
  }

  public String getProductDisplayName() {
     return this.productDisplayName;
  }

  public void setProductDisplayName(String productDisplayName) {
     this.productDisplayName = productDisplayName;
  }

  public Integer getProductEnvironment() {
     return this.productEnvironment;
  }

  public void setProductEnvironment(Integer productEnvironment) {
     this.productEnvironment = productEnvironment;
  }

  public String getProductTag() {
     return this.productTag;
  }

  public void setProductTag(String productTag) {
     this.productTag = productTag;
  }

  public String getProductVersion() {
     return this.productVersion;
  }

  public void setProductVersion(String productVersion) {
     this.productVersion = productVersion;
  }

  public String getRefURL() {
     return this.refURL;
  }

  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public Integer getSmartLicenseProductID() {
     return this.smartLicenseProductID;
  }

  public void setSmartLicenseProductID(Integer smartLicenseProductID) {
     this.smartLicenseProductID = smartLicenseProductID;
  }


  @Path("smartlicense")
  @XmlRootElement(name = "results")
  public static class SmartLicenseProductInfoList extends BaseApiListBean<SmartLicenseProductInfo> {
    @XmlElementWrapper(name = "smartlicenseproductinfos")
    @XmlElement(name = "smartlicenseproductinfo")
    public List<SmartLicenseProductInfo> getItems() {
      return items;
    }

    public void setItems(List<SmartLicenseProductInfo> items) {
      this.items = items;
    }
  }
}
