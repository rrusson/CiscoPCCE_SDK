using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





public class ImportContactBase : BaseApiBean {
  private string? accountNumber;
  private string? baseUrlfromRefUrl;
  private int callResultOverall;
  private CallStatusEnum callStatusEnum;
  private string? correlationId;
  private ReferenceBean department;
  private string? firstName;
  private int? id;
  private string? idFromRefUrl;
  private string? lastName;
  private string? refURL;

  public string? AccountNumber
  {
      get => accountNumber;
      set => accountNumber = value;
  }


  public void setAccountNumber(String accountNumber) {
     this.accountNumber = accountNumber;
  }

  public string? BaseUrlfromRefUrl
  {
      get => baseUrlfromRefUrl;
      set => baseUrlfromRefUrl = value;
  }


  public void setBaseUrlfromRefUrl(String baseUrlfromRefUrl) {
     this.baseUrlfromRefUrl = baseUrlfromRefUrl;
  }

  public int CallResultOverall
  {
      get => callResultOverall;
      set => callResultOverall = value;
  }


  public void setCallResultOverall(int callResultOverall) {
     this.callResultOverall = callResultOverall;
  }

  [XmlElement("callStatus")]
  public CallStatusEnum CallStatusEnum
  {
      get => callStatusEnum;
      set => callStatusEnum = value;
  }


  public void setCallStatusEnum(CallStatusEnum callStatusEnum) {
     this.callStatusEnum = callStatusEnum;
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

  public string? FirstName
  {
      get => firstName;
      set => firstName = value;
  }


  public void setFirstName(String firstName) {
     this.firstName = firstName;
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

  public string? LastName
  {
      get => lastName;
      set => lastName = value;
  }


  public void setLastName(String lastName) {
     this.lastName = lastName;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }


}

}