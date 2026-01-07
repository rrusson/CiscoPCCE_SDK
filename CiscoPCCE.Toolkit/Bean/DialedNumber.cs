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


  public void setBaseUrlfromRefUrl(String baseUrlfromRefUrl) {
     this.baseUrlfromRefUrl = baseUrlfromRefUrl;
  }

  public ReferenceBean CallType
  {
      get => callType;
      set => callType = value;
  }


  public void setCallType(ReferenceBean callType) {
     this.callType = callType;
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

  public ReferenceBean Datacenter
  {
      get => datacenter;
      set => datacenter = value;
  }


  public void setDatacenter(ReferenceBean datacenter) {
     this.datacenter = datacenter;
  }

  public ReferenceBean Department
  {
      get => department;
      set => department = value;
  }


  public void setDepartment(ReferenceBean department) {
     this.department = department;
  }

  public string? Description
  {
      get => description;
      set => description = value;
  }


  public void setDescription(String description) {
     this.description = description;
  }

  [XmlElement("dialedNumberRecords")]
  [XmlElement("dialedNumberRecord")]
  public List<DialedNumberRecord>? DialedNumberRecords
  {
      get => dialedNumberRecords;
      set => dialedNumberRecords = value;
  }


  public void setDialedNumberRecords(List<DialedNumberRecord> dialedNumberRecords) {
     this.dialedNumberRecords = dialedNumberRecords;
  }

  public string? DialedNumberString
  {
      get => dialedNumberString;
      set => dialedNumberString = value;
  }


  public void setDialedNumberString(String dialedNumberString) {
     this.dialedNumberString = dialedNumberString;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }


  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  public bool? MarkDeletable
  {
      get => markDeletable;
      set => markDeletable = value;
  }


  public void setMarkDeletable(Boolean markDeletable) {
     this.markDeletable = markDeletable;
  }

  public ReferenceBean MediaRoutingDomain
  {
      get => mediaRoutingDomain;
      set => mediaRoutingDomain = value;
  }


  public void setMediaRoutingDomain(ReferenceBean mediaRoutingDomain) {
     this.mediaRoutingDomain = mediaRoutingDomain;
  }

  public string? Name
  {
      get => name;
      set => name = value;
  }


  public void setName(String name) {
     this.name = name;
  }

  public string? PcsEnabledDialedNumberPattern
  {
      get => pcsEnabledDialedNumberPattern;
      set => pcsEnabledDialedNumberPattern = value;
  }


  public void setPcsEnabledDialedNumberPattern(String pcsEnabledDialedNumberPattern) {
     this.pcsEnabledDialedNumberPattern = pcsEnabledDialedNumberPattern;
  }

  [XmlElement("peripheralSet")]
  public ReferenceBean PeripheralSet
  {
      get => peripheralSet;
      set => peripheralSet = value;
  }


  public void setPeripheralSet(ReferenceBean peripheralSet) {
     this.peripheralSet = peripheralSet;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public string? RingtoneName
  {
      get => ringtoneName;
      set => ringtoneName = value;
  }


  public void setRingtoneName(String ringtoneName) {
     this.ringtoneName = ringtoneName;
  }

  public int? RoutingType
  {
      get => routingType;
      set => routingType = value;
  }


  public void setRoutingType(int? routingType) {
     this.routingType = routingType;
  }


  // Path("dialednumber")
  [XmlRoot("results")]
  public class DialedNumberList : BaseApiListBean<DialedNumber> {
    [XmlElement("dialedNumbers")]
    [XmlElement("dialedNumber")]
   
    public override List<DialedNumber>? GetItems() => items;

    public override void SetItems(List<DialedNumber>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<DialedNumber>? items)
    {
        this.items = items;
    }
  }
}

}