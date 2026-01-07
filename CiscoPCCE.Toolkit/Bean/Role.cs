using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("role")
[XmlRoot("role")]
public class Role : BaseApiBean {
  private List<ReferenceBean>? administrators;
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private string? correlationId;
  private ReferenceBean department;
  private string? description;
  private List<Feature>? features;
  private string? idFromRefUrl;
  private string? name;
  private string? refURL;
  private bool? systemDefined;

  [XmlElement("administrators")]
  [XmlElement("administrator")]
  public List<ReferenceBean>? Administrators
  {
      get => administrators;
      set => administrators = value;
  }


  public void setAdministrators(List<ReferenceBean> administrators) {
     this.administrators = administrators;
  }

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

  [XmlElement("accessList")]
  [XmlElement("feature")]
  public List<Feature>? Features
  {
      get => features;
      set => features = value;
  }


  public void setFeatures(List<Feature> features) {
     this.features = features;
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

  public bool? SystemDefined
  {
      get => systemDefined;
      set => systemDefined = value;
  }


  public void setSystemDefined(Boolean systemDefined) {
     this.systemDefined = systemDefined;
  }


  // Path("role")
  [XmlRoot("results")]
  public class RoleList : BaseApiListBean<Role> {
    [XmlElement("roles")]
    [XmlElement("role")]
   
    public override List<Role>? GetItems() => items;

    public override void SetItems(List<Role>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<Role>? items)
    {
        this.items = items;
    }
  }
}

}