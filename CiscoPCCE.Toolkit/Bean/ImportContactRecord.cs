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

  public string? BaseUrlfromRefUrl
  {
      get => baseUrlfromRefUrl;
      set => baseUrlfromRefUrl = value;
  }

  public int CallResultOverall
  {
      get => callResultOverall;
      set => callResultOverall = value;
  }

  [XmlElement("callStatus")]
  public CallStatusEnum CallStatusEnum
  {
      get => callStatusEnum;
      set => callStatusEnum = value;
  }

  public int CallsMade
  {
      get => callsMade;
      set => callsMade = value;
  }

  public string? CorrelationId
  {
      get => correlationId;
      set => correlationId = value;
  }

  public ReferenceBean Department
  {
      get => department;
      set => department = value;
  }

  public string? FirstName
  {
      get => firstName;
      set => firstName = value;
  }

  public int? Id
  {
      get => id;
      set => id = value;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }

  public DateTime? ImportDate
  {
      get => importDate;
      set => importDate = value;
  }

  public string? LastName
  {
      get => lastName;
      set => lastName = value;
  }

  [XmlElement("phone01")]
  public PhoneFields Phone01Fields
  {
      get => phone01Fields;
      set => phone01Fields = value;
  }

  [XmlElement("phone02")]
  public PhoneFields Phone02Fields
  {
      get => phone02Fields;
      set => phone02Fields = value;
  }

  [XmlElement("phone03")]
  public PhoneFields Phone03Fields
  {
      get => phone03Fields;
      set => phone03Fields = value;
  }

  [XmlElement("phone04")]
  public PhoneFields Phone04Fields
  {
      get => phone04Fields;
      set => phone04Fields = value;
  }

  [XmlElement("phone05")]
  public PhoneFields Phone05Fields
  {
      get => phone05Fields;
      set => phone05Fields = value;
  }

  [XmlElement("phone06")]
  public PhoneFields Phone06Fields
  {
      get => phone06Fields;
      set => phone06Fields = value;
  }

  [XmlElement("phone07")]
  public PhoneFields Phone07Fields
  {
      get => phone07Fields;
      set => phone07Fields = value;
  }

  [XmlElement("phone08")]
  public PhoneFields Phone08Fields
  {
      get => phone08Fields;
      set => phone08Fields = value;
  }

  [XmlElement("phone09")]
  public PhoneFields Phone09Fields
  {
      get => phone09Fields;
      set => phone09Fields = value;
  }

  [XmlElement("phone10")]
  public PhoneFields Phone10Fields
  {
      get => phone10Fields;
      set => phone10Fields = value;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }

  // Path("import")
  [XmlRoot("results")]
  public class ImportContactRecordList : BaseApiListBean<ImportContactRecord> {    public override List<ImportContactRecord>? GetItems() => items;

    public override void SetItems(List<ImportContactRecord>? value) => items = value;

  }
}

}