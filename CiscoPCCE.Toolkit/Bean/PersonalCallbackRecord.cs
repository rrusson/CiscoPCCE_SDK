using System.Xml.Serialization;
using System.Collections.Generic;
using System;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("personalcallback")
[XmlRoot("personalCallback")]
public class PersonalCallbackRecord : BaseApiBean {
  private string? accountNumber;
  private ReferenceBean agent;
  private string? agentId;
  private string? baseUrlfromRefUrl;
  private Short callResult;
  private CallStatusEnum callStatusEnum;
  private DateTime? callbackDateTime;
  private ReferenceBean campaign;
  private string? campaignDn;
  private int? campaignId;
  private string? correlationId;
  private ReferenceBean department;
  private string? firstName;
  private int? id;
  private string? idFromRefUrl;
  private string? lastName;
  private int? maxAttempts;
  private int? peripheralId;
  private string? phone;
  private string? refURL;

  public string? AccountNumber
  {
      get => accountNumber;
      set => accountNumber = value;
  }


  public void setAccountNumber(String accountNumber) {
     this.accountNumber = accountNumber;
  }

  public ReferenceBean Agent
  {
      get => agent;
      set => agent = value;
  }


  public void setAgent(ReferenceBean agent) {
     this.agent = agent;
  }

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

  public Short CallResult
  {
      get => callResult;
      set => callResult = value;
  }


  public void setCallResult(Short callResult) {
     this.callResult = callResult;
  }

  [XmlElement("callStatus")]
  public CallStatusEnum CallStatusEnum
  {
      get => callStatusEnum;
      set => callStatusEnum = value;
  }


  public void setCallStatusEnum(CallStatusEnum callStatusEnum) {
     this.callStatusEnum = callStatusEnum;
  }

  public DateTime? CallbackDateTime
  {
      get => callbackDateTime;
      set => callbackDateTime = value;
  }


  public void setCallbackDateTime(Date callbackDateTime) {
     this.callbackDateTime = callbackDateTime;
  }

  public ReferenceBean Campaign
  {
      get => campaign;
      set => campaign = value;
  }


  public void setCampaign(ReferenceBean campaign) {
     this.campaign = campaign;
  }

  public string? CampaignDn
  {
      get => campaignDn;
      set => campaignDn = value;
  }


  public void setCampaignDn(String campaignDn) {
     this.campaignDn = campaignDn;
  }

  public int? CampaignId
  {
      get => campaignId;
      set => campaignId = value;
  }


  public void setCampaignId(int? campaignId) {
     this.campaignId = campaignId;
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

  public string? FirstName
  {
      get => firstName;
      set => firstName = value;
  }


  public void setFirstName(String firstName) {
     this.firstName = firstName;
  }

  public int? Id
  {
      get => id;
      set => id = value;
  }


  public void setId(int? id) {
     this.id = id;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }


  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  public string? LastName
  {
      get => lastName;
      set => lastName = value;
  }


  public void setLastName(String lastName) {
     this.lastName = lastName;
  }

  public int? MaxAttempts
  {
      get => maxAttempts;
      set => maxAttempts = value;
  }


  public void setMaxAttempts(int? maxAttempts) {
     this.maxAttempts = maxAttempts;
  }

  public int? PeripheralId
  {
      get => peripheralId;
      set => peripheralId = value;
  }


  public void setPeripheralId(int? peripheralId) {
     this.peripheralId = peripheralId;
  }

  public string? Phone
  {
      get => phone;
      set => phone = value;
  }


  public void setPhone(String phone) {
     this.phone = phone;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }


  // Path("personalcallback")
  [XmlRoot("results")]
  public class PersonalCallbackRecordList : BaseApiListBean<PersonalCallbackRecord> {
    [XmlElement("personalCallbacks")]
    [XmlElement("personalCallback")]
   
    public override List<PersonalCallbackRecord>? GetItems() => items;

    public override void SetItems(List<PersonalCallbackRecord>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<PersonalCallbackRecord>? items)
    {
        this.items = items;
    }
  }
}

}