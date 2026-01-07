using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





public class PhoneFields : BaseApiBean {
  private int callResult;
  private bool? dstObserved;
  private int gmtOffset;
  private string? number;

  public int CallResult
  {
      get => callResult;
      set => callResult = value;
  }


  public void setCallResult(int callResult) {
     this.callResult = callResult;
  }

  public bool? DstObserved
  {
      get => dstObserved;
      set => dstObserved = value;
  }


  public void setDstObserved(bool? dstObserved) {
     this.dstObserved = dstObserved;
  }

  public int GmtOffset
  {
      get => gmtOffset;
      set => gmtOffset = value;
  }


  public void setGmtOffset(int gmtOffset) {
     this.gmtOffset = gmtOffset;
  }

  public string? Number
  {
      get => number;
      set => number = value;
  }


  public void setNumber(String number) {
     this.number = number;
  }


}

}