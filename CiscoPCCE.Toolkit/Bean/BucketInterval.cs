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

  public string? Name
  {
      get => name;
      set => name = value;
  }


  public void setName(String name) {
     this.name = name;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public int? UpperBound1
  {
      get => upperBound1;
      set => upperBound1 = value;
  }


  public void setUpperBound1(int? upperBound1) {
     this.upperBound1 = upperBound1;
  }

  public int? UpperBound2
  {
      get => upperBound2;
      set => upperBound2 = value;
  }


  public void setUpperBound2(int? upperBound2) {
     this.upperBound2 = upperBound2;
  }

  public int? UpperBound3
  {
      get => upperBound3;
      set => upperBound3 = value;
  }


  public void setUpperBound3(int? upperBound3) {
     this.upperBound3 = upperBound3;
  }

  public int? UpperBound4
  {
      get => upperBound4;
      set => upperBound4 = value;
  }


  public void setUpperBound4(int? upperBound4) {
     this.upperBound4 = upperBound4;
  }

  public int? UpperBound5
  {
      get => upperBound5;
      set => upperBound5 = value;
  }


  public void setUpperBound5(int? upperBound5) {
     this.upperBound5 = upperBound5;
  }

  public int? UpperBound6
  {
      get => upperBound6;
      set => upperBound6 = value;
  }


  public void setUpperBound6(int? upperBound6) {
     this.upperBound6 = upperBound6;
  }

  public int? UpperBound7
  {
      get => upperBound7;
      set => upperBound7 = value;
  }


  public void setUpperBound7(int? upperBound7) {
     this.upperBound7 = upperBound7;
  }

  public int? UpperBound8
  {
      get => upperBound8;
      set => upperBound8 = value;
  }


  public void setUpperBound8(int? upperBound8) {
     this.upperBound8 = upperBound8;
  }

  public int? UpperBound9
  {
      get => upperBound9;
      set => upperBound9 = value;
  }


  public void setUpperBound9(int? upperBound9) {
     this.upperBound9 = upperBound9;
  }


  // Path("bucketinterval")
  [XmlRoot("results")]
  public class BucketIntervalList : BaseApiListBean<BucketInterval> {
    [XmlElement("bucketIntervals")]
    [XmlElement("bucketInterval")]
   
    public override List<BucketInterval>? GetItems() => items;

    public override void SetItems(List<BucketInterval>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<BucketInterval>? items)
    {
        this.items = items;
    }
  }
}

}