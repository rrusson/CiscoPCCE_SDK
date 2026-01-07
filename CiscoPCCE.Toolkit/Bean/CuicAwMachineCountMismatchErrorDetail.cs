using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("errorDetail")]
public class CuicAwMachineCountMismatchErrorDetail : BaseApiBean {
  private int? awMachineCount;
  private int? cuicMachineCount;

  public int? AwMachineCount
  {
      get => awMachineCount;
      set => awMachineCount = value;
  }


  public void setAwMachineCount(int? awMachineCount) {
     this.awMachineCount = awMachineCount;
  }

  public int? CuicMachineCount
  {
      get => cuicMachineCount;
      set => cuicMachineCount = value;
  }


  public void setCuicMachineCount(int? cuicMachineCount) {
     this.cuicMachineCount = cuicMachineCount;
  }


}

}