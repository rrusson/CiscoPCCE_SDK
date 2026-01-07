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


  public void setAgentId(String agentId) {
     this.agentId = agentId;
  }

  public string? BaseUrlfromRefUrl
  {
      get => baseUrlfromRefUrl;
      set => baseUrlfromRefUrl = value;
  }


  public void setBaseUrlfromRefUrl(String baseUrlfromRefUrl) {
     this.baseUrlfromRefUrl = baseUrlfromRefUrl;
  }

  public string? CallHomeUrl
  {
      get => callHomeUrl;
      set => callHomeUrl = value;
  }


  public void setCallHomeUrl(String callHomeUrl) {
     this.callHomeUrl = callHomeUrl;
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

  public int? CssmResponseTimeout
  {
      get => cssmResponseTimeout;
      set => cssmResponseTimeout = value;
  }


  public void setCssmResponseTimeout(int? cssmResponseTimeout) {
     this.cssmResponseTimeout = cssmResponseTimeout;
  }

  public ReferenceBean Department
  {
      get => department;
      set => department = value;
  }


  public void setDepartment(ReferenceBean department) {
     this.department = department;
  }

  public int? DeploymentMode
  {
      get => deploymentMode;
      set => deploymentMode = value;
  }


  public void setDeploymentMode(int? deploymentMode) {
     this.deploymentMode = deploymentMode;
  }

  public bool? ExcludeSpikes
  {
      get => excludeSpikes;
      set => excludeSpikes = value;
  }


  public void setExcludeSpikes(Boolean excludeSpikes) {
     this.excludeSpikes = excludeSpikes;
  }

  public bool? Force
  {
      get => force;
      set => force = value;
  }


  public void setForce(Boolean force) {
     this.force = force;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }


  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  public string? IdToken
  {
      get => idToken;
      set => idToken = value;
  }


  public void setIdToken(String idToken) {
     this.idToken = idToken;
  }

  public int? LicenseType
  {
      get => licenseType;
      set => licenseType = value;
  }


  public void setLicenseType(int? licenseType) {
     this.licenseType = licenseType;
  }

  public bool? OutOfCompliance
  {
      get => outOfCompliance;
      set => outOfCompliance = value;
  }


  public void setOutOfCompliance(Boolean outOfCompliance) {
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

  public DateTime? OutOfComplianceStartTime
  {
      get => outOfComplianceStartTime;
      set => outOfComplianceStartTime = value;
  }


  public void setOutOfComplianceStartTime(Date outOfComplianceStartTime) {
     this.outOfComplianceStartTime = outOfComplianceStartTime;
  }

  public string? ProxyHostnameOrIP
  {
      get => proxyHostnameOrIP;
      set => proxyHostnameOrIP = value;
  }


  public void setProxyHostnameOrIP(String proxyHostnameOrIP) {
     this.proxyHostnameOrIP = proxyHostnameOrIP;
  }

  public int? ProxyPort
  {
      get => proxyPort;
      set => proxyPort = value;
  }


  public void setProxyPort(int? proxyPort) {
     this.proxyPort = proxyPort;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public string? ReservationStatus
  {
      get => reservationStatus;
      set => reservationStatus = value;
  }


  public void setReservationStatus(String reservationStatus) {
     this.reservationStatus = reservationStatus;
  }

  public ReservationType ReservationType
  {
      get => reservationType;
      set => reservationType = value;
  }


  public void setReservationType(ReservationType reservationType) {
     this.reservationType = reservationType;
  }

  public string? SerialNumber
  {
      get => serialNumber;
      set => serialNumber = value;
  }


  public void setSerialNumber(String serialNumber) {
     this.serialNumber = serialNumber;
  }

  public string? SmartCode
  {
      get => smartCode;
      set => smartCode = value;
  }


  public void setSmartCode(String smartCode) {
     this.smartCode = smartCode;
  }

  public int? SmartLicenseServerID
  {
      get => smartLicenseServerID;
      set => smartLicenseServerID = value;
  }


  public void setSmartLicenseServerID(int? smartLicenseServerID) {
     this.smartLicenseServerID = smartLicenseServerID;
  }

  public string? SmartTransportUrl
  {
      get => smartTransportUrl;
      set => smartTransportUrl = value;
  }


  public void setSmartTransportUrl(String smartTransportUrl) {
     this.smartTransportUrl = smartTransportUrl;
  }

  public string? TransportGatewayUrl
  {
      get => transportGatewayUrl;
      set => transportGatewayUrl = value;
  }


  public void setTransportGatewayUrl(String transportGatewayUrl) {
     this.transportGatewayUrl = transportGatewayUrl;
  }

  public int? TransportMode
  {
      get => transportMode;
      set => transportMode = value;
  }


  public void setTransportMode(int? transportMode) {
     this.transportMode = transportMode;
  }

  public int? TransportType
  {
      get => transportType;
      set => transportType = value;
  }


  public void setTransportType(int? transportType) {
     this.transportType = transportType;
  }

  public string? TransportUrl
  {
      get => transportUrl;
      set => transportUrl = value;
  }


  public void setTransportUrl(String transportUrl) {
     this.transportUrl = transportUrl;
  }

  public int? UsageMode
  {
      get => usageMode;
      set => usageMode = value;
  }


  public void setUsageMode(int? usageMode) {
     this.usageMode = usageMode;
  }


  // Path("smartlicense")
  [XmlRoot("results")]
  public class SmartLicenseServerInfoList : BaseApiListBean<SmartLicenseServerInfo> {
    [XmlElement("smartlicenseserverinfos")]
    [XmlElement("smartlicenseserverinfo")]
   
    public override List<SmartLicenseServerInfo>? GetItems() => items;

    public override void SetItems(List<SmartLicenseServerInfo>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<SmartLicenseServerInfo>? items)
    {
        this.items = items;
    }
  }
}

}