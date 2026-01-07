using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("dialednumber")
[XmlRoot("dialedNumber")]
public class DialedNumber : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private ReferenceBean callType;
  private int? changeStamp;
  private string? correlationId;
  private ReferenceBean datacenter;
  private ReferenceBean department;
  private string? description;
  private List<DialedNumberRecord>? dialedNumberRecords;
  private string? dialedNumberString;
  private string? idFromRefUrl;
  private bool? markDeletable;
  private ReferenceBean mediaRoutingDomain;
  private string? name;
  private string? pcsEnabledDialedNumberPattern;
  private ReferenceBean peripheralSet;
  private string? refURL;
  private string? ringtoneName;
  private int? routingType;

  public string? BaseUrlfromRefUrl
  {
      get => baseUrlfromRefUrl;
      set => baseUrlfromRefUrl = value;
  }

  public ReferenceBean CallType
  {
      get => callType;
      set => callType = value;
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

  public ReferenceBean Datacenter
  {
      get => datacenter;
      set => datacenter = value;
  }

  public ReferenceBean Department
  {
      get => department;
      set => department = value;
  }

  public string? Description
  {
      get => description;
      set => description = value;
  }

  [XmlElement("dialedNumberRecords")]
  [XmlElement("dialedNumberRecord")]
  public List<DialedNumberRecord>? DialedNumberRecords
  {
      get => dialedNumberRecords;
      set => dialedNumberRecords = value;
  }

  public string? DialedNumberString
  {
      get => dialedNumberString;
      set => dialedNumberString = value;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }

  public bool? MarkDeletable
  {
      get => markDeletable;
      set => markDeletable = value;
  }

  public ReferenceBean MediaRoutingDomain
  {
      get => mediaRoutingDomain;
      set => mediaRoutingDomain = value;
  }

  public string? Name
  {
      get => name;
      set => name = value;
  }

  public string? PcsEnabledDialedNumberPattern
  {
      get => pcsEnabledDialedNumberPattern;
      set => pcsEnabledDialedNumberPattern = value;
  }

  [XmlElement("peripheralSet")]
  public ReferenceBean PeripheralSet
  {
      get => peripheralSet;
      set => peripheralSet = value;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }

  public string? RingtoneName
  {
      get => ringtoneName;
      set => ringtoneName = value;
  }

  public int? RoutingType
  {
      get => routingType;
      set => routingType = value;
  }

  // Path("dialednumber")
  [XmlRoot("results")]
  public class DialedNumberList : BaseApiListBean<DialedNumber> {    public override List<DialedNumber>? GetItems() => items;

    public override void SetItems(List<DialedNumber>? value) => items = value;

  }
}

}