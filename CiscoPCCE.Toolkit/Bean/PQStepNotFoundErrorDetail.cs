using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("errorDetail")]
public class PQStepNotFoundErrorDetail : BaseApiBean {
  private string? pqName;
  private int? step;

  public string? PqName
  {
      get => pqName;
      set => pqName = value;
  }


  public void setPqName(String pqName) {
     this.pqName = pqName;
  }

  public int? Step
  {
      get => step;
      set => step = value;
  }


  public void setStep(int? step) {
     this.step = step;
  }


}

}