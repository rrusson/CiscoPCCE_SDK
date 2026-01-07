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

  public int? ChangeStamp
  {
      get => changeStamp;
      set => changeStamp = value;
  }

  public string? CorrelationId
  {
      get => correlationId;
      set => correlationId = value;
  }

  public ReferenceBean Department
  {
      get => department;
      set => department = value;
  }

  public string? DeploymentType
  {
      get => deploymentType;
      set => deploymentType = value;
  }

  public string? EnforceMode
  {
      get => enforceMode;
      set => enforceMode = value;
  }

  public string? EntitlementDescription
  {
      get => entitlementDescription;
      set => entitlementDescription = value;
  }

  public string? EntitlementDisplayname
  {
      get => entitlementDisplayname;
      set => entitlementDisplayname = value;
  }

  public string? EntitlementTag
  {
      get => entitlementTag;
      set => entitlementTag = value;
  }

  public string? EntitlementVersion
  {
      get => entitlementVersion;
      set => entitlementVersion = value;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }

  public int? LicenseType
  {
      get => licenseType;
      set => licenseType = value;
  }

  public int? LockUsage
  {
      get => lockUsage;
      set => lockUsage = value;
  }

  public int? OutOfCompliance
  {
      get => outOfCompliance;
      set => outOfCompliance = value;
  }

  public int? OutOfComplianceCount
  {
      get => outOfComplianceCount;
      set => outOfComplianceCount = value;
  }

  public int? PeakUsage
  {
      get => peakUsage;
      set => peakUsage = value;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }

  public int? SmartLicenseEntitlementsTagID
  {
      get => smartLicenseEntitlementsTagID;
      set => smartLicenseEntitlementsTagID = value;
  }

  // Path("smartlicense")
  [XmlRoot("results")]
  public class SmartLicenseEntitlementList : BaseApiListBean<SmartLicenseEntitlement> {    public override List<SmartLicenseEntitlement>? GetItems() => items;

    public override void SetItems(List<SmartLicenseEntitlement>? value) => items = value;

  }
}

}