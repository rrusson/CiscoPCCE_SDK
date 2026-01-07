using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("bucketinterval")
[XmlRoot("bucketInterval")]
public class BucketInterval : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private string? correlationId;
  private ReferenceBean department;
  private string? idFromRefUrl;
  private bool? markDeletable;
  private string? name;
  private string? refURL;
  private int? upperBound1;
  private int? upperBound2;
  private int? upperBound3;
  private int? upperBound4;
  private int? upperBound5;
  private int? upperBound6;
  private int? upperBound7;
  private int? upperBound8;
  private int? upperBound9;

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

  public bool? MarkDeletable
  {
      get => markDeletable;
      set => markDeletable = value;
  }

  public string? Name
  {
      get => name;
      set => name = value;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }

  public int? UpperBound1
  {
      get => upperBound1;
      set => upperBound1 = value;
  }

  public int? UpperBound2
  {
      get => upperBound2;
      set => upperBound2 = value;
  }

  public int? UpperBound3
  {
      get => upperBound3;
      set => upperBound3 = value;
  }

  public int? UpperBound4
  {
      get => upperBound4;
      set => upperBound4 = value;
  }

  public int? UpperBound5
  {
      get => upperBound5;
      set => upperBound5 = value;
  }

  public int? UpperBound6
  {
      get => upperBound6;
      set => upperBound6 = value;
  }

  public int? UpperBound7
  {
      get => upperBound7;
      set => upperBound7 = value;
  }

  public int? UpperBound8
  {
      get => upperBound8;
      set => upperBound8 = value;
  }

  public int? UpperBound9
  {
      get => upperBound9;
      set => upperBound9 = value;
  }

  // Path("bucketinterval")
  [XmlRoot("results")]
  public class BucketIntervalList : BaseApiListBean<BucketInterval> {    public override List<BucketInterval>? GetItems() => items;

    public override void SetItems(List<BucketInterval>? value) => items = value;

  }
}

}