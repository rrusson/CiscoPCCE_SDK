using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("/eccpayload")
[XmlRoot("eccpayload")]
public class ECCPayload : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private string? correlationId;
  private ReferenceBean department;
  private string? description;
  private string? idFromRefUrl;
  private string? name;
  private string? refURL;
  private List<ReferenceBean>? variables;

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

  [XmlElement("variables")]
  [XmlElement("variable")]
  public List<ReferenceBean>? Variables
  {
      get => variables;
      set => variables = value;
  }


  public void setVariables(List<ReferenceBean> variables) {
     this.variables = variables;
  }


  // Path("/eccpayload")
  [XmlRoot("results")]
  public class ECCPayloadList : BaseApiListBean<ECCPayload> {
    [XmlElement("eccpayloads")]
    [XmlElement("eccpayload")]
   
    public override List<ECCPayload>? GetItems() => items;

    public override void SetItems(List<ECCPayload>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<ECCPayload>? items)
    {
        this.items = items;
    }
  }
}

}