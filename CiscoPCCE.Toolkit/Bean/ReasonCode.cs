using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("reasoncode")
[XmlRoot("reasonCode")]
public class ReasonCode : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private string? category;
  private int? changeStamp;
  private int? code;
  private string? correlationId;
  private ReferenceBean department;
  private string? description;
  private string? idFromRefUrl;
  private bool? isGlobal;
  private bool? markDeletable;
  private ReasonTypeEnum reasonType;
  private string? refURL;
  private string? text;

  public string? BaseUrlfromRefUrl
  {
      get => baseUrlfromRefUrl;
      set => baseUrlfromRefUrl = value;
  }

  public string? Category
  {
      get => category;
      set => category = value;
  }

  public int? ChangeStamp
  {
      get => changeStamp;
      set => changeStamp = value;
  }

  public int? Code
  {
      get => code;
      set => code = value;
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

  public bool? IsGlobal
  {
      get => isGlobal;
      set => isGlobal = value;
  }

  public bool? MarkDeletable
  {
      get => markDeletable;
      set => markDeletable = value;
  }

  public ReasonTypeEnum ReasonType
  {
      get => reasonType;
      set => reasonType = value;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }

  public string? Text
  {
      get => text;
      set => text = value;
  }

  // Path("reasoncode")
  [XmlRoot("results")]
  public class ReasonCodeList : BaseApiListBean<ReasonCode> {    public override List<ReasonCode>? GetItems() => items;

    public override void SetItems(List<ReasonCode>? value) => items = value;

  }
}

}