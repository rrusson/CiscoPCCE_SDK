using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("question")]
public class SurveyQuestion : BaseApiBean {
  private string? dispatchId;
  private string? questionnaireName;

  public string? DispatchId
  {
      get => dispatchId;
      set => dispatchId = value;
  }


  public void setDispatchId(String dispatchId) {
     this.dispatchId = dispatchId;
  }

  public string? QuestionnaireName
  {
      get => questionnaireName;
      set => questionnaireName = value;
  }


  public void setQuestionnaireName(String questionnaireName) {
     this.questionnaireName = questionnaireName;
  }


}

}