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


  public void setAgentCount(int? agentCount) {
     this.agentCount = agentCount;
  }

  public string? ConsiderIf
  {
      get => considerIf;
      set => considerIf = value;
  }


  public void setConsiderIf(String considerIf) {
     this.considerIf = considerIf;
  }

  public string? Description
  {
      get => description;
      set => description = value;
  }


  public void setDescription(String description) {
     this.description = description;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  [XmlElement("terms")]
  [XmlElement("term")]
  public List<Term>? Terms
  {
      get => terms;
      set => terms = value;
  }


  public void setTerms(List<Term> terms) {
     this.terms = terms;
  }

  public int? WaitTime
  {
      get => waitTime;
      set => waitTime = value;
  }


  public void setWaitTime(int? waitTime) {
     this.waitTime = waitTime;
  }


  // Path("precisionqueue")
  [XmlRoot("results")]
  public class StepList : BaseApiListBean<Step> {
    [XmlElement("steps")]
    [XmlElement("step")]
   
    public override List<Step>? GetItems() => items;

    public override void SetItems(List<Step>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<Step>? items)
    {
        this.items = items;
    }
  }
}

}