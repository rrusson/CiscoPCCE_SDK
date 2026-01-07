using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("/pqsteppreview")
[XmlRoot("pqStepPreview")]
public class PrecisionQueueStepPreview : BaseApiBean {
  private int? agentCount;
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private string? correlationId;
  private ReferenceBean department;
  private string? idFromRefUrl;
  private Step step;

  [XmlElement("agentCount")]
  public int? AgentCount
  {
      get => agentCount;
      set => agentCount = value;
  }


  public void setAgentCount(int? agentCount) {
     this.agentCount = agentCount;
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

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }


  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  public Step Step
  {
      get => step;
      set => step = value;
  }


  public void setStep(Step step) {
     this.step = step;
  }


  // Path("/pqsteppreview")
  [XmlRoot("results")]
  public class PrecisionQueueStepPreviewList : BaseApiListBean<PrecisionQueueStepPreview> {
    [XmlElement("pqStepPreviews")]
    [XmlElement("pqStepPreview")]
   
    public override List<PrecisionQueueStepPreview>? GetItems() => items;

    public override void SetItems(List<PrecisionQueueStepPreview>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<PrecisionQueueStepPreview>? items)
    {
        this.items = items;
    }
  }
}

}