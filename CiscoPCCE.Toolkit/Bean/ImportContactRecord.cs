using System.Xml.Serialization;
using System.Collections.Generic;
using System;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("importContact")]
public class ImportContactRecord : BaseApiBean {
  private string? accountNumber;
  private string? baseUrlfromRefUrl;
  private int callResultOverall;
  private CallStatusEnum callStatusEnum;
  private int callsMade;
  private string? correlationId;
  private ReferenceBean department;
  private string? firstName;
  private int? id;
  private string? idFromRefUrl;
  private DateTime? importDate;
  private string? lastName;
  private PhoneFields phone01Fields;
  private PhoneFields phone02Fields;
  private PhoneFields phone03Fields;
  private PhoneFields phone04Fields;
  private PhoneFields phone05Fields;
  private PhoneFields phone06Fields;
  private PhoneFields phone07Fields;
  private PhoneFields phone08Fields;
  private PhoneFields phone09Fields;
  private PhoneFields phone10Fields;
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

  public int CallsMade
  {
      get => callsMade;
      set => callsMade = value;
  }


  public void setCallsMade(int callsMade) {
     this.callsMade = callsMade;
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

  public DateTime? ImportDate
  {
      get => importDate;
      set => importDate = value;
  }


  public void setImportDate(Date importDate) {
     this.importDate = importDate;
  }

  public string? LastName
  {
      get => lastName;
      set => lastName = value;
  }


  public void setLastName(String lastName) {
     this.lastName = lastName;
  }

  [XmlElement("phone01")]
  public PhoneFields Phone01Fields
  {
      get => phone01Fields;
      set => phone01Fields = value;
  }


  public void setPhone01Fields(PhoneFields phone01Fields) {
     this.phone01Fields = phone01Fields;
  }

  [XmlElement("phone02")]
  public PhoneFields Phone02Fields
  {
      get => phone02Fields;
      set => phone02Fields = value;
  }


  public void setPhone02Fields(PhoneFields phone02Fields) {
     this.phone02Fields = phone02Fields;
  }

  [XmlElement("phone03")]
  public PhoneFields Phone03Fields
  {
      get => phone03Fields;
      set => phone03Fields = value;
  }


  public void setPhone03Fields(PhoneFields phone03Fields) {
     this.phone03Fields = phone03Fields;
  }

  [XmlElement("phone04")]
  public PhoneFields Phone04Fields
  {
      get => phone04Fields;
      set => phone04Fields = value;
  }


  public void setPhone04Fields(PhoneFields phone04Fields) {
     this.phone04Fields = phone04Fields;
  }

  [XmlElement("phone05")]
  public PhoneFields Phone05Fields
  {
      get => phone05Fields;
      set => phone05Fields = value;
  }


  public void setPhone05Fields(PhoneFields phone05Fields) {
     this.phone05Fields = phone05Fields;
  }

  [XmlElement("phone06")]
  public PhoneFields Phone06Fields
  {
      get => phone06Fields;
      set => phone06Fields = value;
  }


  public void setPhone06Fields(PhoneFields phone06Fields) {
     this.phone06Fields = phone06Fields;
  }

  [XmlElement("phone07")]
  public PhoneFields Phone07Fields
  {
      get => phone07Fields;
      set => phone07Fields = value;
  }


  public void setPhone07Fields(PhoneFields phone07Fields) {
     this.phone07Fields = phone07Fields;
  }

  [XmlElement("phone08")]
  public PhoneFields Phone08Fields
  {
      get => phone08Fields;
      set => phone08Fields = value;
  }


  public void setPhone08Fields(PhoneFields phone08Fields) {
     this.phone08Fields = phone08Fields;
  }

  [XmlElement("phone09")]
  public PhoneFields Phone09Fields
  {
      get => phone09Fields;
      set => phone09Fields = value;
  }


  public void setPhone09Fields(PhoneFields phone09Fields) {
     this.phone09Fields = phone09Fields;
  }

  [XmlElement("phone10")]
  public PhoneFields Phone10Fields
  {
      get => phone10Fields;
      set => phone10Fields = value;
  }


  public void setPhone10Fields(PhoneFields phone10Fields) {
     this.phone10Fields = phone10Fields;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }


  // Path("import")
  [XmlRoot("results")]
  public class ImportContactRecordList : BaseApiListBean<ImportContactRecord> {
    [XmlElement("importContacts")]
    [XmlElement("importContact")]
   
    public override List<ImportContactRecord>? GetItems() => items;

    public override void SetItems(List<ImportContactRecord>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<ImportContactRecord>? items)
    {
        this.items = items;
    }
  }
}

}