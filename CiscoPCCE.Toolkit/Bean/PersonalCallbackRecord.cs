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
  private short? callResult;
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

  public ReferenceBean Agent
  {
      get => agent;
      set => agent = value;
  }

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

  public short? CallResult
  {
      get => callResult;
      set => callResult = value;
  }

  [XmlElement("callStatus")]
  public CallStatusEnum CallStatusEnum
  {
      get => callStatusEnum;
      set => callStatusEnum = value;
  }

  public DateTime? CallbackDateTime
  {
      get => callbackDateTime;
      set => callbackDateTime = value;
  }

  public ReferenceBean Campaign
  {
      get => campaign;
      set => campaign = value;
  }

  public string? CampaignDn
  {
      get => campaignDn;
      set => campaignDn = value;
  }

  public int? CampaignId
  {
      get => campaignId;
      set => campaignId = value;
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

  public string? FirstName
  {
      get => firstName;
      set => firstName = value;
  }

  public int? Id
  {
      get => id;
      set => id = value;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }

  public string? LastName
  {
      get => lastName;
      set => lastName = value;
  }

  public int? MaxAttempts
  {
      get => maxAttempts;
      set => maxAttempts = value;
  }

  public int? PeripheralId
  {
      get => peripheralId;
      set => peripheralId = value;
  }

  public string? Phone
  {
      get => phone;
      set => phone = value;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }

  // Path("personalcallback")
  [XmlRoot("results")]
  public class PersonalCallbackRecordList : BaseApiListBean<PersonalCallbackRecord> {    public override List<PersonalCallbackRecord>? GetItems() => items;

    public override void SetItems(List<PersonalCallbackRecord>? value) => items = value;

  }
}

}