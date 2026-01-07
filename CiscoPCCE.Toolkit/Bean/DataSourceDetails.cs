using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





public class DataSourceDetails : BaseApiBean {
  private DataSourceAddressRef address;
  private string? baseUrlfromRefUrl;
  private string? correlationId;
  private ReferenceBean department;
  private int? id;
  private string? idFromRefUrl;
  private string? password;
  private string? refURL;
  private string? userName;

  public DataSourceAddressRef Address
  {
      get => address;
      set => address = value;
  }


  public void setAddress(DataSourceAddressRef address) {
     this.address = address;
  }

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

  public string? Password
  {
      get => password;
      set => password = value;
  }


  public void setPassword(String password) {
     this.password = password;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public string? UserName
  {
      get => userName;
      set => userName = value;
  }


  public void setUserName(String userName) {
     this.userName = userName;
  }


}

}