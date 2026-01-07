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

  public string? BaseUrlfromRefUrl
  {
      get => baseUrlfromRefUrl;
      set => baseUrlfromRefUrl = value;
  }

  public int? ChangeStamp
  {
      get => changeStamp;
      set => changeStamp = value;
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

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }

  public Step Step
  {
      get => step;
      set => step = value;
  }

  // Path("/pqsteppreview")
  [XmlRoot("results")]
  public class PrecisionQueueStepPreviewList : BaseApiListBean<PrecisionQueueStepPreview> {    public override List<PrecisionQueueStepPreview>? GetItems() => items;

    public override void SetItems(List<PrecisionQueueStepPreview>? value) => items = value;

  }
}

}