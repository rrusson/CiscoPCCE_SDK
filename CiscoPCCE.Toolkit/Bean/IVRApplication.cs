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

  public string? CreateDateTime
  {
      get => createDateTime;
      set => createDateTime = value;
  }


  public void setCreateDateTime(String createDateTime) {
     this.createDateTime = createDateTime;
  }

  public ReferenceBean Department
  {
      get => department;
      set => department = value;
  }


  public void setDepartment(ReferenceBean department) {
     this.department = department;
  }

  public string? FileName
  {
      get => fileName;
      set => fileName = value;
  }


  public void setFileName(String fileName) {
     this.fileName = fileName;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }


  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public string? Size
  {
      get => size;
      set => size = value;
  }


  public void setSize(String size) {
     this.size = size;
  }


  // Path("transferablefiles")
  [XmlRoot("results")]
  public class IVRApplicationList : BaseApiListBean<IVRApplication> {
    [XmlElement("IVRApplications")]
    [XmlElement("IVRApplication")]
   
    public override List<IVRApplication>? GetItems() => items;

    public override void SetItems(List<IVRApplication>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<IVRApplication>? items)
    {
        this.items = items;
    }
  }
}

}