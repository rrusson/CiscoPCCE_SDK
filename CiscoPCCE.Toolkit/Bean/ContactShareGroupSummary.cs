using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("contactsharegroup")
[XmlRoot("contactShareGroupSummary")]
public class ContactShareGroupSummary : BaseApiBean {
  private string? acceptQueueIf;
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private ReferenceBean contactShareRule;
  private string? correlationId;
  private ReferenceBean department;
  private string? description;
  private string? idFromRefUrl;
  private string? name;
  private int? queueCount;
  private string? refURL;

  public string? AcceptQueueIf
  {
      get => acceptQueueIf;
      set => acceptQueueIf = value;
  }

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

  public ReferenceBean ContactShareRule
  {
      get => contactShareRule;
      set => contactShareRule = value;
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

  public string? Description
  {
      get => description;
      set => description = value;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }

  public string? Name
  {
      get => name;
      set => name = value;
  }

  public int? QueueCount
  {
      get => queueCount;
      set => queueCount = value;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }

  // Path("contactsharegroup")
  [XmlRoot("results")]
  public class ContactShareGroupSummaryList : BaseApiListBean<ContactShareGroupSummary> {    public override List<ContactShareGroupSummary>? GetItems() => items;

    public override void SetItems(List<ContactShareGroupSummary>? value) => items = value;

  }
}

}