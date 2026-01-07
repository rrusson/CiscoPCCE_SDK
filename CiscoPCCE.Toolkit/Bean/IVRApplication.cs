using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("transferablefiles")
[XmlRoot("IVRApplication")]
public class IVRApplication : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private string? correlationId;
  private string? createDateTime;
  private ReferenceBean department;
  private string? fileName;
  private string? idFromRefUrl;
  private string? refURL;
  private string? size;

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

  public string? CreateDateTime
  {
      get => createDateTime;
      set => createDateTime = value;
  }

  public ReferenceBean Department
  {
      get => department;
      set => department = value;
  }

  public string? FileName
  {
      get => fileName;
      set => fileName = value;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }

  public string? Size
  {
      get => size;
      set => size = value;
  }

  // Path("transferablefiles")
  [XmlRoot("results")]
  public class IVRApplicationList : BaseApiListBean<IVRApplication> {    public override List<IVRApplication>? GetItems() => items;

    public override void SetItems(List<IVRApplication>? value) => items = value;

  }
}

}