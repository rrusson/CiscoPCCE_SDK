using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("smartlicense")
[XmlRoot("smartlicenseentitlement")]
public class SmartLicenseEntitlement : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private string? correlationId;
  private ReferenceBean department;
  private string? deploymentType;
  private string? enforceMode;
  private string? entitlementDescription;
  private string? entitlementDisplayname;
  private string? entitlementTag;
  private string? entitlementVersion;
  private string? idFromRefUrl;
  private int? licenseType;
  private int? lockUsage;
  private int? outOfCompliance;
  private int? outOfComplianceCount;
  private int? peakUsage;
  private string? refURL;
  private int? smartLicenseEntitlementsTagID;

  public string? BaseUrlfromRefUrl
  {
      get => baseUrlfromRefUrl;
      set => baseUrlfromRefUrl = value;
  }


  public void setBaseUrlfromRefUrl(String baseUrlfromRefUrl) {
     this.baseUrlfromRefUrl = baseUrlfromRefUrl;
  }

  public int? ChangeStamp
  {
      get => changeStamp;
      set => changeStamp = value;
  }


  public void setChangeStamp(int? changeStamp) {
     this.changeStamp = changeStamp;
  }

  public string? CorrelationId
  {
      get => correlationId;
      set => correlationId = value;
  }


  public void setCorrelationId(String correlationId) {
     this.correlationId = correlationId;
  }

  public ReferenceBean Department
  {
      get => department;
      set => department = value;
  }


  public void setDepartment(ReferenceBean department) {
     this.department = department;
  }

  public string? DeploymentType
  {
      get => deploymentType;
      set => deploymentType = value;
  }


  public void setDeploymentType(String deploymentType) {
     this.deploymentType = deploymentType;
  }

  public string? EnforceMode
  {
      get => enforceMode;
      set => enforceMode = value;
  }


  public void setEnforceMode(String enforceMode) {
     this.enforceMode = enforceMode;
  }

  public string? EntitlementDescription
  {
      get => entitlementDescription;
      set => entitlementDescription = value;
  }


  public void setEntitlementDescription(String entitlementDescription) {
     this.entitlementDescription = entitlementDescription;
  }

  public string? EntitlementDisplayname
  {
      get => entitlementDisplayname;
      set => entitlementDisplayname = value;
  }


  public void setEntitlementDisplayname(String entitlementDisplayname) {
     this.entitlementDisplayname = entitlementDisplayname;
  }

  public string? EntitlementTag
  {
      get => entitlementTag;
      set => entitlementTag = value;
  }


  public void setEntitlementTag(String entitlementTag) {
     this.entitlementTag = entitlementTag;
  }

  public string? EntitlementVersion
  {
      get => entitlementVersion;
      set => entitlementVersion = value;
  }


  public void setEntitlementVersion(String entitlementVersion) {
     this.entitlementVersion = entitlementVersion;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }


  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  public int? LicenseType
  {
      get => licenseType;
      set => licenseType = value;
  }


  public void setLicenseType(int? licenseType) {
     this.licenseType = licenseType;
  }

  public int? LockUsage
  {
      get => lockUsage;
      set => lockUsage = value;
  }


  public void setLockUsage(int? lockUsage) {
     this.lockUsage = lockUsage;
  }

  public int? OutOfCompliance
  {
      get => outOfCompliance;
      set => outOfCompliance = value;
  }


  public void setOutOfCompliance(int? outOfCompliance) {
     this.outOfCompliance = outOfCompliance;
  }

  public int? OutOfComplianceCount
  {
      get => outOfComplianceCount;
      set => outOfComplianceCount = value;
  }


  public void setOutOfComplianceCount(int? outOfComplianceCount) {
     this.outOfComplianceCount = outOfComplianceCount;
  }

  public int? PeakUsage
  {
      get => peakUsage;
      set => peakUsage = value;
  }


  public void setPeakUsage(int? peakUsage) {
     this.peakUsage = peakUsage;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public int? SmartLicenseEntitlementsTagID
  {
      get => smartLicenseEntitlementsTagID;
      set => smartLicenseEntitlementsTagID = value;
  }


  public void setSmartLicenseEntitlementsTagID(int? smartLicenseEntitlementsTagID) {
     this.smartLicenseEntitlementsTagID = smartLicenseEntitlementsTagID;
  }


  // Path("smartlicense")
  [XmlRoot("results")]
  public class SmartLicenseEntitlementList : BaseApiListBean<SmartLicenseEntitlement> {
    [XmlElement("smartlicenseentitlements")]
    [XmlElement("smartlicenseentitlement")]
   
    public override List<SmartLicenseEntitlement>? GetItems() => items;

    public override void SetItems(List<SmartLicenseEntitlement>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<SmartLicenseEntitlement>? items)
    {
        this.items = items;
    }
  }
}

}