using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("survey")]
public class Survey : BaseApiBean {
  private string? application;
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private string? correlationId;
  private ReferenceBean department;
  private string? enterpriseName;
  private string? idFromRefUrl;
  private bool? markDeletable;
  private SurveyQuestion question;
  private string? refURL;
  private int? surveyType;

  public string? Application
  {
      get => application;
      set => application = value;
  }


  public void setApplication(String application) {
     this.application = application;
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

  public string? EnterpriseName
  {
      get => enterpriseName;
      set => enterpriseName = value;
  }


  public void setEnterpriseName(String enterpriseName) {
     this.enterpriseName = enterpriseName;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }


  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  public bool? MarkDeletable
  {
      get => markDeletable;
      set => markDeletable = value;
  }


  public void setMarkDeletable(Boolean markDeletable) {
     this.markDeletable = markDeletable;
  }

  [XmlElement("surveyDetail")]
  public SurveyQuestion Question
  {
      get => question;
      set => question = value;
  }


  public void setQuestion(SurveyQuestion question) {
     this.question = question;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public int? SurveyType
  {
      get => surveyType;
      set => surveyType = value;
  }


  public void setSurveyType(int? surveyType) {
     this.surveyType = surveyType;
  }


}

}