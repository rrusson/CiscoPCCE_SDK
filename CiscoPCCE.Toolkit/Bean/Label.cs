using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("globalsetting")
[XmlRoot("label")]
public class Label : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private string? correlationId;
  private ReferenceBean datacenter;
  private ReferenceBean department;
  private string? idFromRefUrl;
  private ReferenceBean networkTarget;
  private string? refURL;

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

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }

  public ReferenceBean NetworkTarget
  {
      get => networkTarget;
      set => networkTarget = value;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }

  // Path("globalsetting")
  [XmlRoot("results")]
  public class LabelList : BaseApiListBean<Label> {    public override List<Label>? GetItems() => items;

    public override void SetItems(List<Label>? value) => items = value;

  }
}

}