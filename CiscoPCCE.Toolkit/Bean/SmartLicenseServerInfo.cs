using System.Xml.Serialization;
using System.Collections.Generic;
using System;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("smartlicense")
[XmlRoot("smartlicenseserverinfo")]
public class SmartLicenseServerInfo : BaseApiBean {
  private string? agentId;
  private string? baseUrlfromRefUrl;
  private string? callHomeUrl;
  private int? changeStamp;
  private string? correlationId;
  private int? cssmResponseTimeout;
  private ReferenceBean department;
  private int? deploymentMode;
  private bool? excludeSpikes;
  private bool? force;
  private string? idFromRefUrl;
  private string? idToken;
  private int? licenseType;
  private bool? outOfCompliance;
  private int? outOfComplianceCount;
  private DateTime? outOfComplianceStartTime;
  private string? proxyHostnameOrIP;
  private int? proxyPort;
  private string? refURL;
  private string? reservationStatus;
  private ReservationType reservationType;
  private string? serialNumber;
  private string? smartCode;
  private int? smartLicenseServerID;
  private string? smartTransportUrl;
  private string? transportGatewayUrl;
  private int? transportMode;
  private int? transportType;
  private string? transportUrl;
  private int? usageMode;

  public string? AgentId
  {
      get => agentId;
      set => agentId = value;
  }

  public string? BaseUrlfromRefUrl
  {
      get => baseUrlfromRefUrl;
      set => baseUrlfromRefUrl = value;
  }

  public string? CallHomeUrl
  {
      get => callHomeUrl;
      set => callHomeUrl = value;
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

  public int? CssmResponseTimeout
  {
      get => cssmResponseTimeout;
      set => cssmResponseTimeout = value;
  }

  public ReferenceBean Department
  {
      get => department;
      set => department = value;
  }

  public int? DeploymentMode
  {
      get => deploymentMode;
      set => deploymentMode = value;
  }

  public bool? ExcludeSpikes
  {
      get => excludeSpikes;
      set => excludeSpikes = value;
  }

  public bool? Force
  {
      get => force;
      set => force = value;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }

  public string? IdToken
  {
      get => idToken;
      set => idToken = value;
  }

  public int? LicenseType
  {
      get => licenseType;
      set => licenseType = value;
  }

  public bool? OutOfCompliance
  {
      get => outOfCompliance;
      set => outOfCompliance = value;
  }

  public int? OutOfComplianceCount
  {
      get => outOfComplianceCount;
      set => outOfComplianceCount = value;
  }

  public DateTime? OutOfComplianceStartTime
  {
      get => outOfComplianceStartTime;
      set => outOfComplianceStartTime = value;
  }

  public string? ProxyHostnameOrIP
  {
      get => proxyHostnameOrIP;
      set => proxyHostnameOrIP = value;
  }

  public int? ProxyPort
  {
      get => proxyPort;
      set => proxyPort = value;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }

  public string? ReservationStatus
  {
      get => reservationStatus;
      set => reservationStatus = value;
  }

  public ReservationType ReservationType
  {
      get => reservationType;
      set => reservationType = value;
  }

  public string? SerialNumber
  {
      get => serialNumber;
      set => serialNumber = value;
  }

  public string? SmartCode
  {
      get => smartCode;
      set => smartCode = value;
  }

  public int? SmartLicenseServerID
  {
      get => smartLicenseServerID;
      set => smartLicenseServerID = value;
  }

  public string? SmartTransportUrl
  {
      get => smartTransportUrl;
      set => smartTransportUrl = value;
  }

  public string? TransportGatewayUrl
  {
      get => transportGatewayUrl;
      set => transportGatewayUrl = value;
  }

  public int? TransportMode
  {
      get => transportMode;
      set => transportMode = value;
  }

  public int? TransportType
  {
      get => transportType;
      set => transportType = value;
  }

  public string? TransportUrl
  {
      get => transportUrl;
      set => transportUrl = value;
  }

  public int? UsageMode
  {
      get => usageMode;
      set => usageMode = value;
  }

  // Path("smartlicense")
  [XmlRoot("results")]
  public class SmartLicenseServerInfoList : BaseApiListBean<SmartLicenseServerInfo> {    public override List<SmartLicenseServerInfo>? GetItems() => items;

    public override void SetItems(List<SmartLicenseServerInfo>? value) => items = value;

  }
}

}