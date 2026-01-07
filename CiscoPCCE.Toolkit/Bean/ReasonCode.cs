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


  public void setBaseUrlfromRefUrl(String baseUrlfromRefUrl) {
     this.baseUrlfromRefUrl = baseUrlfromRefUrl;
  }

  public string? Category
  {
      get => category;
      set => category = value;
  }


  public void setCategory(String category) {
     this.category = category;
  }

  public int? ChangeStamp
  {
      get => changeStamp;
      set => changeStamp = value;
  }


  public void setChangeStamp(int? changeStamp) {
     this.changeStamp = changeStamp;
  }

  public int? Code
  {
      get => code;
      set => code = value;
  }


  public void setCode(int? code) {
     this.code = code;
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

  public string? Description
  {
      get => description;
      set => description = value;
  }


  public void setDescription(String description) {
     this.description = description;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }


  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  public bool? IsGlobal
  {
      get => isGlobal;
      set => isGlobal = value;
  }


  public void setIsGlobal(Boolean isGlobal) {
     this.isGlobal = isGlobal;
  }

  public bool? MarkDeletable
  {
      get => markDeletable;
      set => markDeletable = value;
  }


  public void setMarkDeletable(Boolean markDeletable) {
     this.markDeletable = markDeletable;
  }

  public ReasonTypeEnum ReasonType
  {
      get => reasonType;
      set => reasonType = value;
  }


  public void setReasonType(ReasonTypeEnum reasonType) {
     this.reasonType = reasonType;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public string? Text
  {
      get => text;
      set => text = value;
  }


  public void setText(String text) {
     this.text = text;
  }


  // Path("reasoncode")
  [XmlRoot("results")]
  public class ReasonCodeList : BaseApiListBean<ReasonCode> {
    [XmlElement("reasonCodes")]
    [XmlElement("reasonCode")]
   
    public override List<ReasonCode>? GetItems() => items;

    public override void SetItems(List<ReasonCode>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<ReasonCode>? items)
    {
        this.items = items;
    }
  }
}

}