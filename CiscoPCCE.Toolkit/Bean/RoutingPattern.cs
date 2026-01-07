using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("routingpattern")
[XmlRoot("routingPattern")]
public class RoutingPattern : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private string? configParam;
  private string? correlationId;
  private ReferenceBean datacenter;
  private ReferenceBean department;
  private string? description;
  private string? destination;
  private string? idFromRefUrl;
  private string? pattern;
  private int? patternType;
  private string? refURL;
  private int? rnaTimeout;
  private bool? sendToOriginator;

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

  public string? ConfigParam
  {
      get => configParam;
      set => configParam = value;
  }


  public void setConfigParam(String configParam) {
     this.configParam = configParam;
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

  public string? Destination
  {
      get => destination;
      set => destination = value;
  }


  public void setDestination(String destination) {
     this.destination = destination;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }


  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  public string? Pattern
  {
      get => pattern;
      set => pattern = value;
  }


  public void setPattern(String pattern) {
     this.pattern = pattern;
  }

  public int? PatternType
  {
      get => patternType;
      set => patternType = value;
  }


  public void setPatternType(int? patternType) {
     this.patternType = patternType;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public int? RnaTimeout
  {
      get => rnaTimeout;
      set => rnaTimeout = value;
  }


  public void setRnaTimeout(int? rnaTimeout) {
     this.rnaTimeout = rnaTimeout;
  }

  public bool? SendToOriginator
  {
      get => sendToOriginator;
      set => sendToOriginator = value;
  }


  public void setSendToOriginator(Boolean sendToOriginator) {
     this.sendToOriginator = sendToOriginator;
  }


  // Path("routingpattern")
  [XmlRoot("results")]
  public class RoutingPatternList : BaseApiListBean<RoutingPattern> {
    [XmlElement("routingPatterns")]
    [XmlElement("routingPattern")]
   
    public override List<RoutingPattern>? GetItems() => items;

    public override void SetItems(List<RoutingPattern>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<RoutingPattern>? items)
    {
        this.items = items;
    }
  }
}

}