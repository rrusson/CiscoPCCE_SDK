using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("precisionqueue")
[XmlRoot("step")]
public class Step : BaseApiBean {
  private int? agentCount;
  private string? considerIf;
  private string? description;
  private string? refURL;
  private List<Term>? terms;
  private int? waitTime;

  public int? AgentCount
  {
      get => agentCount;
      set => agentCount = value;
  }

  public string? ConsiderIf
  {
      get => considerIf;
      set => considerIf = value;
  }

  public string? Description
  {
      get => description;
      set => description = value;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }

  [XmlElement("terms")]
  [XmlElement("term")]
  public List<Term>? Terms
  {
      get => terms;
      set => terms = value;
  }

  public int? WaitTime
  {
      get => waitTime;
      set => waitTime = value;
  }

  // Path("precisionqueue")
  [XmlRoot("results")]
  public class StepList : BaseApiListBean<Step> {    public override List<Step>? GetItems() => items;

    public override void SetItems(List<Step>? value) => items = value;

  }
}

}