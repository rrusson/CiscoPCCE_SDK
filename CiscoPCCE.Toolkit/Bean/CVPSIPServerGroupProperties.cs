using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("sipservergroupproperties")
[XmlRoot("CVP")]
public class CVPSIPServerGroupProperties : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private string? correlationId;
  private ReferenceBean department;
  private int? id;
  private string? idFromRefUrl;
  private string? refURL;
  private SIPServerGroupProperties sipServerGroupProperties;

  public string? BaseUrlfromRefUrl
  {
      get => baseUrlfromRefUrl;
      set => baseUrlfromRefUrl = value;
  }


  public void setBaseUrlfromRefUrl(String baseUrlfromRefUrl) {
     this.baseUrlfromRefUrl = baseUrlfromRefUrl;
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

  public int? Id
  {
      get => id;
      set => id = value;
  }


  public void setId(int? id) {
     this.id = id;
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

  public SIPServerGroupProperties SipServerGroupProperties
  {
      get => sipServerGroupProperties;
      set => sipServerGroupProperties = value;
  }


  public void setSipServerGroupProperties(SIPServerGroupProperties sipServerGroupProperties) {
     this.sipServerGroupProperties = sipServerGroupProperties;
  }


  // Path("sipservergroupproperties")
  [XmlRoot("results")]
  public class CVPSIPServerGroupPropertiesList : BaseApiListBean<CVPSIPServerGroupProperties> {
    [XmlElement("CVPs")]
    [XmlElement("CVP")]
   
    public override List<CVPSIPServerGroupProperties>? GetItems() => items;

    public override void SetItems(List<CVPSIPServerGroupProperties>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<CVPSIPServerGroupProperties>? items)
    {
        this.items = items;
    }
  }
}

}