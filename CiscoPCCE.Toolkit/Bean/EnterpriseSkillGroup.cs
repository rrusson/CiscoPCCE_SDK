using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("enterpriseroute")
[XmlRoot("enterpriseSkillGroup")]
public class EnterpriseSkillGroup : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private string? correlationId;
  private ReferenceBean department;
  private int entityID;
  private string? idFromRefUrl;
  private string? name;
  private string? refURL;

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

  public int EntityID
  {
      get => entityID;
      set => entityID = value;
  }


  public void setEntityID(int entityID) {
     this.entityID = entityID;
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


  // Path("enterpriseroute")
  [XmlRoot("results")]
  public class EnterpriseSkillGroupList : BaseApiListBean<EnterpriseSkillGroup> {
    [XmlElement("enterpriseSkillGroups")]
    [XmlElement("enterpriseSkillGroup")]
   
    public override List<EnterpriseSkillGroup>? GetItems() => items;

    public override void SetItems(List<EnterpriseSkillGroup>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<EnterpriseSkillGroup>? items)
    {
        this.items = items;
    }
  }
}

}