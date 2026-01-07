using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("capacityRule")]
public class CapacityCheckResult : BaseApiBean {
  private long? actual;
  private Object capacityCheckOperation;
  private long? max;
  private string? name;

  public long? Actual
  {
      get => actual;
      set => actual = value;
  }


  public void setActual(long? actual) {
     this.actual = actual;
  }

  public Object CapacityCheckOperation
  {
      get => capacityCheckOperation;
      set => capacityCheckOperation = value;
  }


  public void setCapacityCheckOperation(Object capacityCheckOperation) {
     this.capacityCheckOperation = capacityCheckOperation;
  }

  public long? Max
  {
      get => max;
      set => max = value;
  }


  public void setMax(long? max) {
     this.max = max;
  }

  [XmlElement("name")]
  public string? Name
  {
      get => name;
      set => name = value;
  }


  public void setName(String name) {
     this.name = name;
  }


}

}